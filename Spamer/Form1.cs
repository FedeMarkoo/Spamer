using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Task.Delay(500);
            Direccion();
            InitializeComponent();
            if (Primeriso())
            {
                Carga();
                time = DateTime.Now;
                StartsAsync();
            }
        }

        private void Direccion()
        {
            Dir = Application.ExecutablePath;
            Dir = Dir.Substring(0, Dir.LastIndexOf("\\") + 1);
            if (Dir.Contains("34Proyectos\\Spamer\\Spamer\\bin\\Debug"))
            {
                if (Dir.Contains("C:\\Users\\fe"))
                    Dir = Dir.Replace("Proyectos\\Spamer\\Spamer\\bin\\Debug", "Proyectos\\Ventacelulares");
                else
                    Dir = Dir.Replace("Proyectos\\Spamer\\Spamer\\bin\\Debug", "Proyectos\\SpamerFace C++");
            }
        }

        public async Task StartsAsync()
        {
            Espera = 5;
            while (Espera > 0)
            {
                Start.Text = "Se va a esperar " + Espera-- + " segundos";
                await Task.Delay(1000);
            }
            Start.Visible = false;
            Navegar();
            await Task.Delay(1000 * 60 * 30);
            Application.Exit();
        }

        private void WebBrowser1_DocumentCompletedAsync(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = titulo + "Pagina Completa";
            CGrupos = LGrupos.CheckedItems.Count;
            CLinks = LLinks.CheckedItems.Count;
            CComentarios = LComentario.CheckedItems.Count;
            if (!Start.Visible && !iniciando)
            {
                if (webBrowser1.Url.ToString().Contains("login"))
                {
                    //Inicio(); 
                }
                else if (webBrowser1.Url.ToString().Contains("facebook.com/share.php") && webBrowser1.Url.ToString().Length > 45)
                {
                    if (Actual >= CGrupos)
                        Application.Exit();

                    int offsetgrupo = 0;
                    while (LGrupos.Items[offsetgrupo].ToString() != LGrupos.CheckedItems[Actual].ToString() && offsetgrupo < 200)
                        offsetgrupo++;

                    LGrupos.SetSelected(Actual, true);
                    if (JustOneByOne)
                    {
                        JustOneByOne = false;
                        PublicarAsync();
                    }
                }
                else if (++Actual < CGrupos && !Listo.Visible)
                {
                    Navegar();
                }
                else
                {
                    Text = titulo + "Saliendo";
                    Application.Exit();
                }
            }
        }

        public void Carga()
        {
            Text = titulo + "Cargando Datos";
            int i = 0;
            bool op = true;
            CGrupos = (new Random()).Next(35, 45);
            string[] TComentario = null;
            string[] Grupos = null;
            string[] Links = null;
            TComentario = System.IO.File.ReadAllText(Dir + "TextoDeComentario.txt", Encoding.Unicode).Split(';', (char)StringSplitOptions.RemoveEmptyEntries);
            Grupos = System.IO.File.ReadAllLines(Dir + "Grupos.txt", Encoding.Unicode);
            Links = System.IO.File.ReadAllLines(Dir + "Url a compartir.txt", Encoding.Unicode);
            foreach (var item in Links)
            {
                if (op && Links[i] == ";")
                    op = false;
                if (Links[i] != ";")
                    LLinks.Items.Add(Links[i], op);
                i++;
            }
            i = 0;
            op = true;
            foreach (var item in Grupos)
            {
                if ((op && i >= CGrupos) || Grupos[i] == ";")
                    op = false;
                if (Grupos[i] != ";")
                    LGrupos.Items.Add(Grupos[i], op);
                i++;
            }
            i = 0;
            op = true;
            foreach (var item in TComentario)
            {
                if (op && TComentario[i] == ";")
                    op = false;
                if (TComentario[i] != ";")
                    LComentario.Items.Add(TComentario[i].Substring((i == 0) ? 0 : 2, TComentario[i].Length - ((i == 0) ? 2 : ((i == TComentario.Length - 1) ? 2 : 4))), op);
                i++;
            }

            CGrupos = LGrupos.CheckedItems.Count;
            CLinks = LLinks.CheckedItems.Count;
            CComentarios = LComentario.CheckedItems.Count;

        }

        public bool Primeriso()
        {
            if (!System.IO.File.Exists(Dir + "TextoDeComentario.txt") || !System.IO.File.Exists(Dir + "Grupos.txt") || !System.IO.File.Exists(Dir + "Url a compartir.txt"))
            {
                Grupostext.Visible = true;
                Comentariotext.Visible = true;
                Linkstext.Visible = true;
                if (System.IO.File.Exists(Dir + "TextoDeComentario.txt"))
                    Comentariotext.Text = System.IO.File.ReadAllText(Dir + "TextoDeComentario.txt", Encoding.Unicode);
                if (System.IO.File.Exists(Dir + "Grupos.txt"))
                    Grupostext.Text = System.IO.File.ReadAllText(Dir + "Grupos.txt", Encoding.Unicode);
                if (System.IO.File.Exists(Dir + "Url a compartir.txt"))
                    Linkstext.Text = System.IO.File.ReadAllText(Dir + "Url a compartir.txt", Encoding.Unicode);

                Listo.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                Emojis.Visible = true;
                label3.Visible = true;

                LLinks.Visible = false;
                LGrupos.Visible = false;
                LComentario.Visible = false;
                webBrowser1.Visible = false;
                Start.Visible = false;

                //MessageBox.Show("Hola! Con este spamer podes elegir los links que queres compartir, en los grupos y con el texto que quieras... los links y grupos tienen que ser en ascii (sin caracteres especiales), el comentario por marketing lo mejor es que si tengan caracteres especiales...");
                MessageBox.Show("Hola! Con este spamer podes elegir los links que queres compartir, en los grupos y con el texto que quieras... el comentario por marketing lo mejor es que tenga caracteres especiales...");
                MessageBox.Show("Podes hacer grupos de links y separarlos con ; \nPor ejemplo:\nwwww.asdasdsad.com\nwww.ewerwer.com\n;\nwww.facebook.com\n;\nwww.gooogle.com\n\n igual con los comentarios... solo que ahi se aletorizan todos mientras que en los links se mezclan solo los que estan dentro del grupo");
                MessageBox.Show("Si editas los arhivos de texto que contienen los grupos, links y comentarios.... POR NADA cambies los nombres y asegurate de guardarlos en codificacion UNICODE.... sino se descajeta todo");
                return false;
            }
            return true;
        }

        public async Task PublicarAsync()
        {
            Text = titulo + "Inicio Publicacion";
            if (Actual + 1 >= CGrupos)
                Application.Exit();

            await Task.Delay(1500);
            await Seleccionar_Grupo();

            await Task.Delay(1500);
            await Escribir_GrupoAsync();

            await Task.Delay(1500);
            Comentario();

            Sigue = true;
            if (webBrowser1.DocumentText.Contains(LGrupos.CheckedItems[Actual].ToString()))
                Fin();
            await Task.Delay(10000);

            if (Sigue)
                Cancelar();
        }

        public void Cancelar()
        {
            Text = titulo + "Fallo... Cancelando";
            foreach (HtmlElement element in webBrowser1.Document.All)
            {
                if (element.InnerText == "Cancelar")
                {
                    element.InvokeMember("Click");
                    return;
                }
            }
        }

        public void Fin()
        {
            Text = titulo + "Finalizando";
            foreach (HtmlElement element in webBrowser1.Document.All)
            {
                if (element.InnerText == "Publicar en Facebook")
                {
                    element.InvokeMember("Click");
                    element.InvokeMember("Click");
                    element.InvokeMember("Click");
                }
            }
        }

        public void Comentario()
        {
            Text = titulo + "Escribiendo Comentario";
            HtmlElement elem = webBrowser1.Document.GetElementFromPoint(new Point(108, 176));
            elem.Focus();
            int select = (new Random()).Next(CComentarios);
            string texto = LComentario.CheckedItems[select].ToString();
            int offset = -1;
            while (texto != LComentario.Items[++offset].ToString()) ;
            LComentario.SetSelected(offset, true);
            texto += " #" + Actual;
            elem.SetAttribute("Value", texto);
            Activate();
            SendKeys.Send(".");
        }

        public async Task Escribir_GrupoAsync()
        {
            Text = titulo + "Escribiendo Nombre de Grupo";
            HtmlElement elem = webBrowser1.Document.GetElementFromPoint(new Point(98, 111));
            string comp = LGrupos.CheckedItems[Actual].ToString().Substring(0, LGrupos.CheckedItems[Actual].ToString().Length - 1);
            string ultimo = LGrupos.CheckedItems[Actual].ToString().Last() + "";

            elem.Focus();
            elem.Focus();
            elem.Focus();
            await Task.Delay(100);
            elem.SetAttribute("value", comp);
            await Task.Delay(100);
            elem.SetAttribute("value", comp);
            await Task.Delay(100);
            elem.SetAttribute("value", comp);
            await Task.Delay(100);
            elem.SetAttribute("value", comp);
            await Task.Delay(100);
            elem.SetAttribute("value", comp);
            await Task.Delay(100);
            elem.SetAttribute("value", comp);
            elem.Focus();
            elem.Focus();
            elem.Focus();
            Activate();
            SendKeys.Send(ultimo);
            await Task.Delay(500);
            Activate();
            SendKeys.Send("{DOWN}{ENTER}");
        }

        public async Task Seleccionar_Grupo()
        {
            Text = titulo + "Preparando Grupo";
            while (!webBrowser1.DocumentText.ToString().Contains("biograf"))
                await Task.Delay(500);
            HtmlElement botton = webBrowser1.Document.GetElementFromPoint(new Point(86, 68));
            botton.InvokeMember("Click");
            while (!webBrowser1.DocumentText.ToString().Contains("grupo"))
                await Task.Delay(500);
            botton = null;
            botton = webBrowser1.Document.GetElementFromPoint(new Point(128, 99));
            foreach (HtmlElement element in webBrowser1.Document.All)
            {
                if (element.InnerText == "Compartir en un grupo")
                {
                    element.InvokeMember("Click");
                    return;
                }
            }
        }

        public void Inicio()
        {
            webBrowser1.Document.GetElementById("email").SetAttribute("value", "@gmail.com");
            webBrowser1.Document.GetElementById("pass").SetAttribute("value", "");
            foreach (HtmlElement html in webBrowser1.Document.GetElementsByTagName(""))
            {
                if (html.InnerText.Contains("iniciar"))
                    html.InvokeMember("Click");
            }
        }

        private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!iniciando)
            {
                if (Actual + 1 >= CGrupos)
                {
                    Application.Exit();
                    return;
                }

                if (e.Url.ToString() != "http://facebook.com/share.php?u=" + link)
                    Navegar();

                TimeSpan asd = DateTime.Now - time;
                TimeSpan asd2;
                if (Actual == 0)
                    asd2 = TimeSpan.FromTicks(asd.Ticks * (CGrupos - Actual) / 1);
                else
                    asd2 = TimeSpan.FromTicks(asd.Ticks * (CGrupos - Actual) / Actual);
                titulo = Actual + "/" + CGrupos + " - " + asd.ToString(@"mm\:ss\:fff") + " - " + asd2.ToString(@"mm\:ss\:fff") + "    " + LGrupos.CheckedItems[Actual] + "  ";
                Text = titulo + "Navegando";
            }
        }

        private void Navegar()
        {
            if (!iniciando)
            {
                Text = titulo + "Navegando....";
                int select = (new Random()).Next(CLinks);
                link = LLinks.CheckedItems[select].ToString();
                int offset = -1;
                while (link != LLinks.Items[++offset].ToString() && offset <= CLinks) ;
                LLinks.SetSelected(offset, true);

                Actual++;
                webBrowser1.Navigate("facebook.com/share.php?u=" + link);
                Sigue = false;
                JustOneByOne = true;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Espera += 15;
            if (Espera > 60)
                Espera = 60;
        }

        private void Listo_Click(object sender, EventArgs e)
        {
            if (Grupostext.Text.Length > 5 && Linkstext.Text.Length > 5 && Comentariotext.Text.Length > 5)
            {
                System.IO.File.WriteAllText(Dir + "Grupos.txt", Grupostext.Text, Encoding.Unicode);
                System.IO.File.WriteAllText(Dir + "Url a compartir.txt", Linkstext.Text, Encoding.Unicode);
                System.IO.File.WriteAllText(Dir + "TextoDeComentario.txt", Comentariotext.Text, Encoding.Unicode);
                if (!System.IO.File.Exists(Dir + "Aletorizar Grupos.ps1"))
                    System.IO.File.WriteAllText(Dir + "Aletorizar Grupos.ps1", "Get-Content 'Grupos.txt' | Sort-Object {Get-Random} | Set-Content 'Grupos.txt' -Encoding Unicode");
                Application.Exit();
            }
            MessageBox.Show("Todos los campos deben estar completos!!");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://es.piliapp.com/facebook-symbols/");
        }

        public DateTime time;
        public bool iniciando = false;
        public string titulo;
        public bool JustOneByOne = true;
        public bool Sigue = false;
        public float act = 0;
        public int Espera = 0;
        public int Actual = 0;
        public int CComentarios = 0;
        public int CLinks = 0;
        public int CGrupos = 0;
        public string link;
        public string TComentario;
        public string Dir;

        private void sesion_Click(object sender, EventArgs e)
        {
            iniciando = true;
            Listo.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            Emojis.Visible = false;
            label3.Visible = false;

            LLinks.Visible = false;
            LGrupos.Visible = false;
            LComentario.Visible = false;
            webBrowser1.Visible = true;
            sesion.Visible = false;
            Start.Visible = false;
            webBrowser1.Navigate("facebook.com");
            webBrowser1.Size = ActiveForm.Size;
        }
    }
}