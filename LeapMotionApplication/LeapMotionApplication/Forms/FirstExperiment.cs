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

namespace LeapMotionApplication.Forms
{
    public partial class FirstExperiment : Form, ILeapEventDelegate
    {
        private int _countFingers;
        private const int deltaTime = 30;
        private int currentTime = 0;
        private const int experimentTime = 600;
        private int goodCurrentTime = 0; // Количество текущих кадров с выполненным условием
        private bool[] rightArm;
        private bool[] leftArm;

        private const int widthZoneVisible = 80;
        private Controller controller;
        private LeapEventListener listener;

        public FirstExperiment()
        {
            InitializeComponent();
            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            Random random = new Random();
            _countFingers = random.Next(1, 10);
            textFingers.Text = "Покажите " + _countFingers.ToString() + " пальцев.";
            rightArm = new bool[5];
            leftArm = new bool[5];
            timeText.Text = "0";
            controller.AddListener(listener);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool CheckFinger(Vector position)
        {
            if (position.x > -widthZoneVisible/2 && position.x < widthZoneVisible/2 && position.z > -widthZoneVisible/2 && position.z < widthZoneVisible/2)
                return true;
            return false;
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

        void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }

        void UpdateTextArm()
        {
            ltext1.Text = leftArm[0].ToString();
            ltext2.Text = leftArm[1].ToString();
            ltext3.Text = leftArm[2].ToString();
            ltext4.Text = leftArm[3].ToString();
            ltext5.Text = leftArm[4].ToString();

            rtext1.Text = rightArm[0].ToString();
            rtext2.Text = rightArm[1].ToString();
            rtext3.Text = rightArm[2].ToString();
            rtext4.Text = rightArm[3].ToString();
            rtext5.Text = rightArm[4].ToString();
        }

        void ExitExperiment(bool result)
        {
            resultText.Visible = true;
            if (result)
                resultText.Text = "Количество показанных пальцев совпало!";
            else
                resultText.Text = "Не было показано нужное количество пальцев.";

            controller.RemoveListener(listener);
        }

        private int CountFinger(bool[] vs)
        {
            int _count = 0;
            for (int i = 0; i < vs.Length; ++i)
                _count += vs[i] ? 1 : 0;
            return _count;
        }

        void newFrameHandler(Frame frame)
        {
            timeText.Text = "Прошло секунд: " + (currentTime / 60).ToString() + " из " + (experimentTime / 60).ToString();

            if (currentTime == experimentTime)
                ExitExperiment(false);

            if (goodCurrentTime == deltaTime)
                ExitExperiment(true);


            foreach (Hand hand in frame.Hands)
            {
                Vector normal = hand.PalmNormal;
                Vector direction = hand.Direction;
                foreach (Finger finger in hand.Fingers)
                {
                    switch (finger.Type)
                    {
                        case Finger.FingerType.TYPE_THUMB:
                            if (hand.IsLeft)
                                leftArm[0] = CheckFinger(finger.TipPosition);
                            else
                                rightArm[0] = CheckFinger(finger.TipPosition);
                            break;
                        case Finger.FingerType.TYPE_INDEX:
                            if (hand.IsLeft)
                                leftArm[1] = CheckFinger(finger.TipPosition);
                            else
                                rightArm[1] = CheckFinger(finger.TipPosition);
                            break;
                        case Finger.FingerType.TYPE_MIDDLE:
                            if (hand.IsLeft)
                                leftArm[2] = CheckFinger(finger.TipPosition);
                            else
                                rightArm[2] = CheckFinger(finger.TipPosition);
                            break;
                        case Finger.FingerType.TYPE_RING:
                            if (hand.IsLeft)
                                leftArm[3] = CheckFinger(finger.TipPosition);
                            else
                                rightArm[3] = CheckFinger(finger.TipPosition);
                            break;
                        case Finger.FingerType.TYPE_PINKY:
                            if (hand.IsLeft)
                                leftArm[4] = CheckFinger(finger.TipPosition);
                            else
                                rightArm[4] = CheckFinger(finger.TipPosition);
                            break;
                    }
                }
                if (CountFinger(leftArm) + CountFinger(rightArm) == _countFingers)
                    goodCurrentTime += 1;
                currentTime += 1;
                UpdateTextArm();
            }
        }



        void Frames_Load(object sender, EventArgs e)
        {

        }

    }
}
