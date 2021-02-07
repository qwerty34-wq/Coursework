﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestElement;

namespace TestControl
{
    public partial class Form1 : Form
    {
        TestElem elem;
        List<string> answs = new List<string>();
        int n = 0;

        List<TestElem> testElems = new List<TestElem>();

        public Form1()
        {
            InitializeComponent();

            ElemBlock(false);
        }

        private void ElemBlock(bool onoff)
        {
            textBox4.Enabled = onoff;
            textBox3.Enabled = onoff;
            checkBox1.Enabled = onoff;
            textBox5.Enabled = onoff;
            button1.Enabled = onoff;
            button2.Enabled = onoff;
            button3.Enabled = onoff;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" && textBox1.Text.Trim() != "")
            {
                ElemBlock(true);
            }
            else
            {
                ElemBlock(false);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                ElemBlock(true);
            }
            else
            {
                ElemBlock(false);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                if (textBox4.Text.Trim() != "" && textBox3.Text.Trim() != "")
                {
                    elem = new TestElem() { Author = textBox1.Text.Trim(), Title = textBox2.Text.Trim(), Question = textBox4.Text.Trim() };

                    answs.Add(textBox3.Text.Trim());

                    if (checkBox1.Checked)
                    {
                        elem.CorectAnswer = textBox3.Text.Trim();
                        checkBox1.Checked = false;
                        checkBox1.Enabled = false;

                        checkBox1.Text = $"IsRight  ({elem.CorectAnswer})";
                    }

                    textBox4.Enabled = false;
                    textBox3.Clear();

                    textBox1.Enabled = textBox2.Enabled = false;

                    ShowInListBox();

                    n++;
                }
            }
            else
            {
                if (textBox3.Text.Trim() != "")
                {
                    answs.Add(textBox3.Text.Trim());

                    if (checkBox1.Checked)
                    {
                        elem.CorectAnswer = textBox3.Text.Trim();
                        checkBox1.Checked = false;
                        checkBox1.Enabled = false;

                        checkBox1.Text = $"IsRight  ({elem.CorectAnswer})";
                    }

                    textBox3.Clear();

                    ShowInListBox();

                    n++;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (n >= 2 && elem.CorectAnswer != null)
            {
                //elem.Answers = answs;
                //foreach (var ans in answs)
                //{
                //    elem.Answers.Add(ans);
                //}
                elem.Answers = new List<string>();
                elem.Answers.AddRange(answs);

                answs.Clear();

                testElems.Add(elem);

                elem = null;

                listBox1.Items.Clear();

                label4.Text = $"Questions  ({testElems.Count()})";

                textBox4.Clear();
                textBox4.Enabled = true;

                checkBox1.Text = "IsRight";

                if (!checkBox1.Enabled)
                {
                    checkBox1.Enabled = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

                n = 0;

                MessageBox.Show($"Author: {testElems[testElems.Count()-1].Author}\nTitle: {testElems[testElems.Count() - 1].Title}\nQuestion: {testElems[testElems.Count() - 1].Question}\nAnswers: {testElems[testElems.Count() - 1].Answers.Count()}\nCorect Answer:{testElems[testElems.Count() - 1].CorectAnswer}");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void ShowInListBox()
        {
            
            listBox1.Items.Add(answs[answs.Count() - 1]);

            //listBox1.Items.Clear();
            //foreach (var ans in answs)
            //{
            //    listBox1.Items.Add(ans);
            //}
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists("Tests"))
            {
                Directory.CreateDirectory("Tests");
            }

            XmlSerializer formatter = new XmlSerializer(typeof(List<TestElem>));

            using (FileStream fs = new FileStream($"Tests/{textBox5.Text}.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, testElems);

                MessageBox.Show("Test saved successfuly");
            }


            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();

            textBox1.Enabled = textBox2.Enabled = true;

            checkBox1.Checked = false;
        }
    }
}
