
namespace study_1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Previous_room = new System.Windows.Forms.Button();
            this.btn_Next_room = new System.Windows.Forms.Button();
            this.tb_Room_description = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Previous_room, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Next_room, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Room_description, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.63248F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Previous_room
            // 
            this.btn_Previous_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Previous_room.Location = new System.Drawing.Point(3, 3);
            this.btn_Previous_room.Name = "btn_Previous_room";
            this.btn_Previous_room.Size = new System.Drawing.Size(521, 143);
            this.btn_Previous_room.TabIndex = 0;
            this.btn_Previous_room.Text = "Previous Room";
            this.btn_Previous_room.UseVisualStyleBackColor = true;
            this.btn_Previous_room.Click += new System.EventHandler(this.btn_Previous_room_Click);
            // 
            // btn_Next_room
            // 
            this.btn_Next_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next_room.Location = new System.Drawing.Point(530, 3);
            this.btn_Next_room.Name = "btn_Next_room";
            this.btn_Next_room.Size = new System.Drawing.Size(522, 143);
            this.btn_Next_room.TabIndex = 1;
            this.btn_Next_room.Text = "Next Room";
            this.btn_Next_room.UseVisualStyleBackColor = true;
            this.btn_Next_room.Click += new System.EventHandler(this.btn_Next_room_Click);
            // 
            // tb_Room_description
            // 
            this.tb_Room_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Room_description.Location = new System.Drawing.Point(3, 152);
            this.tb_Room_description.Multiline = true;
            this.tb_Room_description.Name = "tb_Room_description";
            this.tb_Room_description.Size = new System.Drawing.Size(521, 547);
            this.tb_Room_description.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 702);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Previous_room;
        private System.Windows.Forms.Button btn_Next_room;
        private System.Windows.Forms.TextBox tb_Room_description;
    }
}

