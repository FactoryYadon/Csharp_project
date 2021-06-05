using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_1
{
    public partial class Form1 : Form
    {
        Living_room _living_Room;
        Kitchen_room _kitchen_Room;
        Room _current_Room;
        
        public Form1()
        {
            InitializeComponent();
            initialize_Class();
            show_Inform();
            refresh_form();






        }

        private void btn_Previous_room_Click(object sender, EventArgs e)
        {
            btn_click_confirm();
        }

        private void btn_Next_room_Click(object sender, EventArgs e)
        {
            btn_click_confirm();
        }
    
        private void initialize_Class()
        {
            _living_Room = new Living_room();
            _kitchen_Room = new Kitchen_room();

            _living_Room._Previous_Room = _kitchen_Room;
            _kitchen_Room._Next_Room = _living_Room;

            

            _current_Room = _living_Room;

        }

        private void show_Inform()
        {
            tb_Room_description.AppendText(string.Format("Room Name : {0}", _current_Room.Room_name));
            tb_Room_description.AppendText(Environment.NewLine);
            tb_Room_description.AppendText(string.Format("Room Description : {0}", _current_Room.Room_description));
            tb_Room_description.AppendText(Environment.NewLine);

        }

        private void refresh_form()
        {
            if(_current_Room._Previous_Room == null)
            {
                this.btn_Previous_room.Enabled = false;
                this.btn_Next_room.Enabled = true;

            }

            if (_current_Room._Next_Room == null)
            {
                this.btn_Next_room.Enabled = false;
                this.btn_Previous_room.Enabled = true;

            }



        }

        private void btn_click_confirm()
        {
            if (_current_Room == _living_Room)
            {
                _current_Room = _kitchen_Room;
            }
            else
            {
                _current_Room = _living_Room;
            }
            tb_Room_description.Clear();
            
            show_Inform();
            refresh_form();
        }


    }
}
