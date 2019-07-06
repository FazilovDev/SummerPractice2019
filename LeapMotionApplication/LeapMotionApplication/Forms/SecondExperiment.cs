using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Leap;
using LeapMotionApplication.Model;

namespace LeapMotionApplication.Forms
{
    public partial class SecondExperiment : Form, ILeapEventDelegate
    {
        private Controller controller;
        private LeapEventListener listener;

        private bool[][] pressedFingers;
        private int[][] goodTimes;

        private const int deltaTime = 7;
        private int currentTime = 0;
        private const int experimentTime = 6000;

        private float epsVelocity = 60;
        private const float height = 150;
        private Finger[][] fingers;
        private bool isEndWriteData = false;

        private long countAllPressed = 0;
        private long countAllPressedMotionBad = 0;
        private long countAllPressedMotion = 0;
        private long countTimeMoment = 0;

        List<Press> pressData;
        List<PressMotion> pressMotionData;

        public SecondExperiment()
        {
            InitializeComponent();

            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            pressedFingers = new bool[2][];
            pressedFingers[0] = new bool[5];
            pressedFingers[1] = new bool[5];
            goodTimes = new int[2][];
            goodTimes[0] = new int[5];
            goodTimes[1] = new int[5];
            fingers = new Finger[2][];
            fingers[0] = new Finger[5];
            fingers[1] = new Finger[5];
        }

        delegate void LeapEventDelegate(string EventName);
        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":
                        Debug.WriteLine("Init");
                        break;
                    case "onConnect":
                        this.connectHandler();
                        break;
                    case "onFrame":
                        if (!this.Disposing)
                            this.newFrameHandler(this.controller.Frame());
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }

        private void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }

        private void ExitExperiment(bool result)
        {
            BeginText.Text = result ? "Все гуд" : "Провал";
            controller.RemoveListener(listener);
        }

        private int CheckFingerType(Finger locFinger)
        {
            switch (locFinger.Type)
            {
                case Finger.FingerType.TYPE_THUMB:
                    return 0;
                    
                case Finger.FingerType.TYPE_INDEX:
                    return 1;
                case Finger.FingerType.TYPE_MIDDLE:
                    return 2;
                case Finger.FingerType.TYPE_RING:
                    return 3;
                case Finger.FingerType.TYPE_PINKY:
                    return 4;
                default:
                    return -1;
            }
        }

        private void newFrameHandler(Frame frame)
        {
            if (currentTime == experimentTime)
                ExitExperiment(false);

            for (int i = 0; i < goodTimes.Length; ++i)
                for (int j = 0; j < goodTimes[i].Length; ++j)
                {

                    if (goodTimes[i][j] == deltaTime)
                    {
                        pressedFingers[i][j] = true;
                        PressMotion pressMotion = new PressMotion(fingers[i][j].Type.ToString(), fingers[i][j].TipVelocity, getTimeInSeconds());
                        PressMotionDao.Instance.Insert(pressMotion);
                    }
                    else
                        pressedFingers[i][j] = false;
                }

            foreach (Hand hand in frame.Hands)
                foreach (Finger locFinger in hand.Fingers)
                {
                    try
                    {
                        int typeHand = hand.IsLeft ? 0 : 1;
                        int typeFinger = CheckFingerType(locFinger);
                        if (typeFinger == -1) return;

                        
                        fingers[typeHand][typeFinger] = locFinger;
                        if (locFinger.TipVelocity.y > epsVelocity && locFinger.TipPosition.y > height)
                            goodTimes[typeHand][typeFinger] += 1;
                        else
                            goodTimes[typeHand][typeFinger] = 0;
                    }
                    catch (Exception except)
                    {
                        BeginText.Text = except.ToString();
                    }
                }

            UpdateTextArm();
        }
    
        void UpdateTextArm()
        {
            ltext1.Text = pressedFingers[0][0].ToString();
            ltext2.Text = pressedFingers[0][1].ToString();
            ltext3.Text = pressedFingers[0][2].ToString();
            ltext4.Text = pressedFingers[0][3].ToString();
            ltext5.Text = pressedFingers[0][4].ToString();

            rtext1.Text = pressedFingers[1][0].ToString();
            rtext2.Text = pressedFingers[1][1].ToString();
            rtext3.Text = pressedFingers[1][2].ToString();
            rtext4.Text = pressedFingers[1][3].ToString();
            rtext5.Text = pressedFingers[1][4].ToString();
        }


        private bool isPressed(float y)
        {
            if (y > 50)
                return true;
            return false;
        }

        private void timeText_TextChanged(object sender, EventArgs e)
        {
            text.Text = "Ввод";
        }

        private void timeText_KeyUp(object sender, KeyEventArgs e)
        {
            Press press = new Press(getTimeInSeconds());
            PressDao.Instance.Insert(press);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (text.Text.Length > 0)
                text.Text = "";
        }

        private long getTimeInSeconds()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        }


        private void SecondExperiment_Load(object sender, EventArgs e)
        {

        }

        private void butStop_Click(object sender, EventArgs e)
        {
            if (!isEndWriteData) {
                controller.RemoveListener(listener);
                butStop.Text = "Итоги";
                BeginText.Text = "Эксперимент успешно завершен. Можно узнать результаты эксперимента";
                isEndWriteData = true;
                text.Visible = false;
            }
            else
            {
                panelResult.Visible = true;
                butStop.Visible = false;
            }
        }
        
        private void ReadDataFromDB()
        {
            pressData = new List<Press>();
            pressMotionData = new List<PressMotion>();
            //Начинаем с 1 элемента,т.к. Id хранятся в базе данных начиная с 1
            for (var i = 1; i < PressDao.Instance.Count(); ++i)
                pressData.Add(PressDao.Instance.Get(i));
            for (var i = 1; i < PressMotionDao.Instance.Count(); ++i)
                pressMotionData.Add(PressMotionDao.Instance.Get(i));
        }

        private void PrintResult()
        {
            if (pressData == null)
            {
                outputResult.Text = "Нет данных";
                return;
            }
            long currentTime;
            var countPress = 0;
            var countPressMotion = 0;
            Dictionary<int, PressMotion> currentPressesMotion = new Dictionary<int, PressMotion>();
            float maxVelocityMotion = 0.0f;
            outputResult.Text = "Нажатия с клавиатуры / с LeapMotion";
            outputResultGood.Text = "Нажатия с клавиатуры / с LeapMotion";
            for (var i = 1; i < pressData.Count - 1; ++i)
            {
                currentTime = pressData[i].Time;
                countPress++;
                for (var j = i; j < pressData.Count; ++j)
                    if (pressData[j].Time == currentTime)
                        countPress++;
                for (var j = 1; j < pressMotionData.Count; ++j)
                    if (pressMotionData[j].TimePress == currentTime)
                    {

                        if (pressMotionData[j].TipVelocity[1] > maxVelocityMotion)
                            maxVelocityMotion = pressMotionData[j].TipVelocity[1];
                        currentPressesMotion.Add(currentPressesMotion.Count, pressMotionData[j]);
                        countPressMotion++;
                    }

                float deltaVelocity = 60;

                int countPressMotionNew = 0;
                countAllPressedMotionBad = countAllPressedMotion;
                for (var j = 0; j < currentPressesMotion.Count - 1; ++j)
                    if (Math.Abs(maxVelocityMotion - currentPressesMotion[j].TipVelocity[1]) < deltaVelocity)
                        countPressMotionNew++;

                outputResultGood.Text += Environment.NewLine + "Количество: " + countPress.ToString() +
                    "(клавиатура)   " + countPressMotionNew.ToString() + "(LeapMotion)     " + "Время: " + currentTime.ToString();
                i += countPress - 1;
                outputResult.Text += Environment.NewLine + "Количество: " + countPress.ToString() +
                    "(клавиатура)   " + countPressMotion.ToString() + "(LeapMotion)     " + "Время: " + currentTime.ToString();

                countAllPressed += countPress;
                countAllPressedMotion += countPressMotionNew;
                countTimeMoment++;
                countPress = 0;
                countPressMotion = 0;
            }
        }

        private void PrintMainResult()
        {
            float accurate = (float)countAllPressed / countTimeMoment; // Скорость нажатий на клавиатуру
            float relative = (float)countAllPressedMotion / countTimeMoment; // Скорость обработанных нажатий с LeapMotion
            float badRelative = (float)countAllPressedMotionBad / countTimeMoment;// Скорость необработанных нажатий с LeapMotion

            float absoluteAccurace = Math.Abs(relative - accurate); // Абсолютная погрешность обработанных нажатий
            float absoluteBadAccurace = Math.Abs(badRelative - accurate); // Абсолютная погрешность необработанных нажатий
            float relativeBadAccurace = absoluteBadAccurace / accurate * 100; // Относительная погрешность необработанных нажатий
            float relativeAccurace = absoluteAccurace / accurate * 100; // Относительная погрешность обработанных нажатий

            outputResBad.Text += absoluteBadAccurace.ToString();
            OutputResRelativeBad.Text += relativeBadAccurace.ToString() + "%";
            absAccuracy.Text += absoluteAccurace.ToString();
            relativeAccuracy.Text += relativeAccurace.ToString() + "%";
        }

        private void butResult_Click(object sender, EventArgs e)
        {
            ReadDataFromDB();
            PrintResult();
            PrintMainResult();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            text.Visible = true;
            controller.AddListener(listener);
            butStart.Visible = false;
            butStop.Visible = true;
        }
    }
}