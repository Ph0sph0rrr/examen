﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Enter : Form
    {
        string phone, pass;
        string nameCl;
        string role = "Клиент";
        int idCl, idPrd;

        string nameUs;

        int idUs;






        Database db = new Database();

        public Enter()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            phone = tBxPhEn.Text;
            pass = tBxPasEn.Text;

            if (phone.Length == 11)
            {
                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkCl = new NpgsqlCommand($"SELECT name_surname, id FROM clients WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());

                    NpgsqlDataReader reader = checkCl.ExecuteReader();

                    if (reader.Read())
                    {
                        nameCl = reader.GetString(0);
                        idCl = reader.GetInt32(1);

                        this.Hide();
                        Menu formMenu = new Menu(nameCl, idCl, role, phone);
                        formMenu.Show();
                    }
                    else { MessageBox.Show("Такого пользователя нет"); }

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEnEmp_Click(object sender, EventArgs e)
        {


            phone = tBxPhEn.Text;
            pass = tBxPasEn.Text;
 
            int x = 0;



            // 89666666666
            // 212223




            if (phone.Length == 11)
            {


                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkUs = new NpgsqlCommand($"SELECT name_surname, id FROM admin WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());
                   
                    NpgsqlDataReader reader = checkUs.ExecuteReader();

                    

                    
                    

                    if (reader.Read())
                    {
                        
                        nameUs = reader.GetString(0);
                        idUs = reader.GetInt32(1);
                        role = "Админ";
                        x = 1;
                        this.Hide();
                        Menu formMenu = new Menu(nameUs, idUs, role, phone);
                        formMenu.Show();
                        db.closeConnection();
                        MessageBox.Show("Вы зашли как администратор");
                    }

                    

                    else 
                       
                    

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }

            if (phone.Length == 11)
            {

                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkRab = new NpgsqlCommand($"SELECT name_surname, id FROM employes WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());
                    
                    NpgsqlDataReader readerRab = checkRab.ExecuteReader();

                    if (readerRab.Read())
                    {
                        nameUs = readerRab.GetString(0);
                        idUs = readerRab.GetInt32(1);
                        role = "Исполнитель";
                        x = 1;
                        this.Hide();
                        Menu formMenu = new Menu(nameUs, idUs, role, phone);
                        formMenu.Show();
                        db.closeConnection();
                        MessageBox.Show("Вы зашли как работник");
                    }



                    else
                   

                    db.closeConnection();

                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }



            
            
            if (phone.Length == 11)
            {

                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkUss = new NpgsqlCommand($"SELECT name_surname, id FROM manager WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());

                    NpgsqlDataReader readerUss = checkUss.ExecuteReader();

                    if (readerUss.Read())
                    {
                        nameUs = readerUss.GetString(0);
                        idUs = readerUss.GetInt32(1);
                        role = "Менеджер";
                        x = 1;
                        this.Hide();
                        Menu formMenu = new Menu(nameUs, idUs, role, phone);
                        formMenu.Show();
                        db.closeConnection();
                        MessageBox.Show("Вы зашли как менеджер");
                    }



                    else


                        db.closeConnection();

                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }



            




            //



            if (phone.Length == 11)
            {
                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkCl = new NpgsqlCommand($"SELECT name_surname, id FROM clients WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());

                    NpgsqlDataReader reader = checkCl.ExecuteReader();

                    if (reader.Read())
                    {
                        nameCl = reader.GetString(0);
                        idCl = reader.GetInt32(1);
                        x = 1;
                        role = "Клиент";
                        this.Hide();
                        Menu formMenu = new Menu(nameCl, idCl, role, phone);
                        formMenu.Show();
                        MessageBox.Show("Вы зашли как клиент");
                        db.closeConnection();
                    }
                    else 

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }


            if (x == 0)
            {
                MessageBox.Show("Аккаунта не существует");
            }



        }
        








        private void btnReg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();
        }
    }
}
    



