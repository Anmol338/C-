using OOP_Assignment1_2133112.Data;
using System.Collections;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace OOP_Assignment1_2133112
{
    public partial class Form1 : Form
    {

        DBConnection conn = new DBConnection();

        // Elevator state variables
        private bool elevatorFirst = true;
        private bool elevatorGround = false;
        private bool isMoving = false;
        private bool closedoor = true;
        private bool opendoor = false;
        private bool isdooropening = false;
        private bool isdoorclosing = false;

        // Door position limits
        private int xAxisLeftClose = 255; /* Left limit when door is closed */
        private int xAxisRightClose = 351; /* Right limit when door is closed */
        private int xAxisLeftOpen = 161; /* Left limit when door is open */
        private int xAxisRightOpen = 443; /* Right limit when door is open */

        // Object initialization
        DetailsMw detailsMw = new DetailsMw();
        CrudOperation db = new CrudOperation();


        public Form1()

        {
            InitializeComponent();
            dataInsert();

            floorStatus.Text = "1";
            floorStatus1.Text = "1";
        }


        //Buttons Start


        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(isMoving == true)
            {
                return;
            }
            else if(isMoving == false)
            {
                /*dataInsert();*/
                if (elevatorFirst == true)
                {
                    openDoorFirstFn();

                }
                else if (elevatorGround == true)
                {
                    openDoorGroundFn();

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(isMoving == true)
            {
                return;
            }
            else if(isMoving == false)
            {
                if (elevatorFirst == true)
                {
                    closeDoorFirstFn();

                }
                else if (elevatorGround == true)
                {
                    closeDoorGroundFn();

                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (isMoving == false)
            {
                if (elevatorFirst == true)
                {
                    openDoorFirstFn();
                }
                else if (elevatorGround == true)
                {
                    if (closedoor == false)
                    {
                        closeDoorGroundFn();
                        closedoor = true;
                    }
                    else if (closedoor == true)
                    {
                        timerElevatorUp.Enabled = true;
                    }
                }
            }
        }

        private void btnFirstFloor_Click(object sender, EventArgs e)
        {

            detailsMw.Details = "1st floor";
            detailsMw.Begin_Date = DateTime.Now.ToString("yyyy-MM-dd");
            detailsMw.Begin_Time = DateTime.Now.ToString("HH:mm:ss");
            /*db.Insert(detailsMw);*/
            move_lift_up();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if(isMoving == false)
            {
                if (elevatorGround == true)
                {
                    openDoorGroundFn();
                }
                else if (elevatorFirst == true)
                {
                    if (closedoor == false)
                    {
                        closeDoorGroundFn();
                        closedoor = true;
                    }
                    else if (closedoor == true)
                    {
                        timerElevatorDown.Enabled = true;
                    }
                }
            }
        }

        private void btnGround_Click(object sender, EventArgs e)
        {
            /*dataInsert();*/
            detailsMw.Details = "ground floor";
            detailsMw.Begin_Date = DateTime.Now.ToString("yyyy-MM-dd");
            detailsMw.Begin_Time = DateTime.Now.ToString("HH:mm:ss");
            /*db.Insert(detailsMw);*/
            move_lift_down();
        }

        //Buttons End


        private void timerFirstDoorOpen_Tick(object sender, EventArgs e)
        {
            if (elevatorFirst == true)
            {
                if (pbDoorLeftFirst.Left >= xAxisLeftOpen && pbDoorRightFirst.Left <= xAxisRightOpen)
                {
                    pbDoorLeftFirst.Left -= 1;
                    pbDoorRightFirst.Left += 1;
                }
                else
                {


                    isdooropening = false;
                    isdoorclosing = false;
                    closedoor = false;
                    opendoor = true;

                    timerFirstDoorOpen.Enabled = false;
                    Thread.Sleep(2000);
                    closeDoorFirstFn();
                }
            }
        }

        private void timerFirstDoorClose_Tick(object sender, EventArgs e)
        {
            if (elevatorFirst == true)
            {
                if (pbDoorLeftFirst.Left <= xAxisLeftClose && pbDoorRightFirst.Left >= xAxisRightClose)
                {
                    pbDoorLeftFirst.Left += 1;
                    pbDoorRightFirst.Left -= 1;
                }
                else
                {
                    isdoorclosing = false;
                    isdooropening = false;
                    closedoor = true;
                    opendoor = false;
                    timerFirstDoorClose.Enabled = false;
                }
            }
        }

        private void timerGroundDoorOpen_Tick(object sender, EventArgs e)
        {
            if (elevatorGround == true)
            {
                if (pbLeftDoorGround.Left >= xAxisLeftOpen && pbRightDoorGround.Left <= xAxisRightOpen)
                {
                    pbLeftDoorGround.Left -= 1;
                    pbRightDoorGround.Left += 1;
                }
                else
                {
                    isdooropening = false;
                    isdoorclosing = false;
                    opendoor = true;
                    closedoor = false;
                    timerGroundDoorOpen.Enabled = false;
                    Thread.Sleep(2000);
                    closeDoorGroundFn();
                }
            }
        }

        private void timerGroundDoorClose_Tick(object sender, EventArgs e)
        {
            if (elevatorGround == true)
            {
                if (pbLeftDoorGround.Left <= xAxisLeftClose && pbRightDoorGround.Left >= xAxisRightClose)
                {
                    pbLeftDoorGround.Left += 1;
                    pbRightDoorGround.Left -= 1;
                }
                else
                {
                    isdoorclosing = false;
                    isdooropening = false;
                    closedoor = true;
                    opendoor = false;
                    timerGroundDoorClose.Enabled = false;
                }
            }
        }

        //yeta puge
        private void timerElevatorDown_Tick(object sender, EventArgs e)
        {
            if (elevatorFirst == true)
            {
                if (isdoorclosing == false && isdooropening == false && opendoor == false && closedoor == true)
                {
                    if (pbInsideElevator.Top <= 510)
                    {
                        isMoving = true;
                        btnGround.Enabled = false;
                        btnFirstFloor.Enabled = false;
                        btnClose.Enabled = false;
                        btnOpen.Enabled = false;
                        pbInsideElevator.Top += 10;

                    }
                    else
                    {
                        isMoving = false;
                        btnGround.Enabled = true;
                        btnFirstFloor.Enabled = true;
                        btnClose.Enabled = true;
                        btnOpen.Enabled = true;
                        timerElevatorUp.Enabled = false;
                        timerElevatorDown.Enabled = false;
                        isMoving = false;
                        elevatorFirst = false;
                        elevatorGround = true;
                        openDoorGroundFn();
                    }
                }
            }
        }

        private async void timerElevatorUp_Tick(object sender, EventArgs e)
        {
            if (elevatorGround == true)
            {
                if (isdoorclosing == false && isdooropening == false && opendoor == false && closedoor == true)
                {
                    if (pbInsideElevator.Top >= 110)
                    {
                        isMoving = true;
                        btnGround.Enabled = false;
                        btnFirstFloor.Enabled = false;
                        btnClose.Enabled = false;
                        btnOpen.Enabled = false;
                        pbInsideElevator.Top -= 10;
                    }
                    else
                    {
                        isMoving = false;
                        btnGround.Enabled = true;
                        btnFirstFloor.Enabled = true;
                        btnClose.Enabled = true;
                        btnOpen.Enabled = true;
                        timerElevatorDown.Enabled = false;
                        timerElevatorUp.Enabled = false;
                        isMoving = false;
                        elevatorGround = false;
                        elevatorFirst = true;
                        openDoorFirstFn();
                    }
                }
            }
        }

        //Function

        //function to open door at first floor
        private void openDoorFirstFn()
        {
            detailsMw.Details = "FF door open";
            detailsMw.Begin_Date = DateTime.Now.ToString("yyyy-MM-dd");
            detailsMw.Begin_Time = DateTime.Now.ToString("HH:mm:ss");
            db.Insert(detailsMw);

            isdooropening = true;
            timerFirstDoorClose.Enabled = false;
            timerFirstDoorOpen.Enabled = true;
        }

        //function to open door at ground floor 
        private void openDoorGroundFn()
        {
            detailsMw.Details = "Gf door open";
            detailsMw.Begin_Date = DateTime.Now.ToString("yyyy-MM-dd");
            detailsMw.Begin_Time = DateTime.Now.ToString("HH:mm:ss");
            db.Insert(detailsMw);

            isdooropening = true;

            timerGroundDoorClose.Enabled = false;
            timerGroundDoorOpen.Enabled = true;

        }
        //function to close door at first floor
        private void closeDoorFirstFn()
        {
            detailsMw.Details = "ff door close";
            detailsMw.Begin_Date = DateTime.Now.ToString("yyyy-MM-dd");
            detailsMw.Begin_Time = DateTime.Now.ToString("HH:mm:ss");
            db.Insert(detailsMw);

            isdoorclosing = true;
            timerFirstDoorOpen.Enabled = false;
            timerFirstDoorClose.Enabled = true;

        }

        //function to close door at ground floor
        private void closeDoorGroundFn()
        {
            detailsMw.Details = "gf door close";
            detailsMw.Begin_Date = DateTime.Now.ToString("yyyy-MM-dd");
            detailsMw.Begin_Time = DateTime.Now.ToString("HH:mm:ss");
            db.Insert(detailsMw);

            isdoorclosing = true;
            timerGroundDoorOpen.Enabled = false;
            timerGroundDoorClose.Enabled = true;
        }


        //function to move lift down
        private void move_lift_down()
        {
            timerElevatorUp.Enabled = false;
            timerElevatorDown.Enabled = true;
        }

        //function to move lift up
        private void move_lift_up()
        {
            timerElevatorDown.Enabled = false;
            timerElevatorUp.Enabled = true;
        }


        /*  //lift down button inside
          private void pictureBox_ground_Click(object sender, EventArgs e)
          {
              timerElevatorUp.Enabled = false;
              timerElevatorDown.Enabled = true;
          }*/


        //lift up button inside

        /*   private void pictureBox_firstfloor_Click(object sender, EventArgs e)
           {
               timerElevatorDown.Enabled = false;
               timerElevatorUp.Enabled = true;
           }*/

        //function to insert data to display
        private void dataInsert()
        {
            ArrayList arrayList = db.Displayall();
            data_history.DataSource = arrayList;

        }

        //timer to take the lift down
        private void timer_liftdown_Tick(object sender, EventArgs e)
        {
            if (elevatorFirst == true)
            {
                if (isdoorclosing == false && isdooropening == false && opendoor == false && closedoor == true)
                {
                    if (pbInsideElevator.Top <= 600)
                    {
                        btnGround.Enabled = false;
                        btnFirstFloor.Enabled = false;
                        btnClose.Enabled = false;
                        btnOpen.Enabled = false;
                        pbInsideElevator.Top += 10;

                    }
                    else
                    {
                        btnGround.Enabled = true;
                        btnFirstFloor.Enabled = true;
                        btnClose.Enabled = true;
                        btnOpen.Enabled = true;
                        timerElevatorUp.Enabled = false;
                        timerElevatorDown.Enabled = false;
                        isMoving = false;
                        elevatorFirst = false;
                        elevatorGround = true;
                        openDoorGroundFn();
                    }
                }
            }
        }

        //timer to take the lift up

        private void timer_liftup_Tick(object sender, EventArgs e)
        {
            if (elevatorGround == true)
            {
                if (isdoorclosing == false && isdooropening == false && opendoor == false && closedoor == true)
                {
                    if (pbInsideElevator.Top >= 120)
                    {
                        btnGround.Enabled = false;
                        btnFirstFloor.Enabled = false;
                        btnClose.Enabled = false;
                        btnOpen.Enabled = false;
                        pbInsideElevator.Top -= 10;

                    }
                    else
                    {
                        btnGround.Enabled = true;
                        btnFirstFloor.Enabled = true;
                        btnClose.Enabled = true;
                        btnOpen.Enabled = true;
                        timerElevatorDown.Enabled = false;
                        timerElevatorUp.Enabled = false;
                        isMoving = false;
                        elevatorGround = false;
                        elevatorFirst = true;
                        openDoorFirstFn();
                    }
                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataInsert();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            data_history.DataSource = null;
        }
    }

}