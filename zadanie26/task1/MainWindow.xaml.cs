using System;
using System.Windows;
using System.Xml;

namespace z1
{
    public partial class MainWindow : Window
    {
        string path = string.Empty;
        static XmlDocument xDoc = new XmlDocument();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            path = textBoxPath.Text;
            PrintXmlContent(path);
        }
        private void PrintXmlContent(string localPath)
        {
            textBoxContent.Text = string.Empty;
            try
            {
                xDoc.Load(localPath);
                XmlElement xRoot = xDoc.DocumentElement;


                foreach (XmlNode xnode in xRoot)
                {
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("name");
                        if (attr != null)
                            textBoxContent.Text += attr.Value + " | ";
                    }
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "number")
                        {
                            textBoxContent.Text += "Номер автобуса: " + childnode.InnerText + " | ";
                        }
                        if (childnode.Name == "toPlace")
                        {
                            textBoxContent.Text += "Пункт назначения: " + childnode.InnerText + '\n';
                        }
                    }
                }

            }
            catch (Exception)
            {
                path = String.Empty;
                MessageBox.Show("Неверный путь к файлу!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            PritnSomeXmlElement(path);

        }
        private void PritnSomeXmlElement(string path)
        {
            if (path != string.Empty)
            {
                if (path == textBoxPath.Text)
                {
                    int count = 0;
                    textBoxResult.Text = string.Empty;
                    xDoc.Load(path);
                    XmlElement xRoot = xDoc.DocumentElement;
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("name");
                            if (attr != null && attr.Value == textBoxSearch.Text)
                            {
                                count++;
                                textBoxResult.Text += attr.Value + " | ";
                                foreach (XmlNode childnode in xnode.ChildNodes)
                                {
                                    if (childnode.Name == "number")
                                    {
                                        textBoxResult.Text += "Номер автобуса: " + childnode.InnerText + " | ";
                                    }
                                    if (childnode.Name == "toPlace")
                                    {
                                        textBoxResult.Text += "Пункт назначения: " + childnode.InnerText + '\n';
                                    }
                                }
                            }
                        }
                    }
                    if (count == 0)
                    {
                        textBoxResult.Text = "Совпадений не найдено";
                    }
                }
                else MessageBox.Show("Путь изменён, сначала откройте файл!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else MessageBox.Show("Откройте файл!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (path != string.Empty)
            {
                if (path == textBoxPath.Text)
                {
                    xDoc.Load(path);
                    XmlElement xRoot = xDoc.DocumentElement;
                    string deleteName = textBoxDelete.Text;
                    try
                    {
                        DeleteNodeByAttName(deleteName, xDoc);
                        xDoc.Save(path);
                        textBoxResult.Text = $"Автобус {deleteName} успешно удален";
                        PrintXmlContent(path);
                    }
                    catch (Exception)
                    {
                        if (deleteName == String.Empty)
                            textBoxResult.Text = $"Автобус не найден";
                        else textBoxResult.Text = $"Автобус {deleteName} не найден";

                    }
                }
                else MessageBox.Show("Путь изменён, сначала откройте файл!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else MessageBox.Show("Откройте файл!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void DeleteNodeByAttName(string name, XmlDocument xmlDoc)
        {
            XmlNode node = xmlDoc.SelectSingleNode(String.Format("/busCenter/bus[@name='{0}']", name));

            if (node != null)
            {
                xmlDoc.SelectSingleNode("busCenter").RemoveChild(node);
            }
            else throw new Exception();
        }

        private void buttonExists_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (path == textBoxPath.Text)
            {
                if (path != string.Empty)
                {
                    xmlAddWindows xmlAddWindows = new xmlAddWindows();
                    xmlAddWindows.path = textBoxPath.Text;
                    xmlAddWindows.ShowDialog();
                }
                else MessageBox.Show("Введите путь к файлу!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (path == "") MessageBox.Show("Откройте файл!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            else MessageBox.Show("Путь изменён, сначала откройте файл!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void textBoxContent_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}


