using Microsoft.AspNet.SignalR.Client;

namespace ChatAppSignalR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //define connection
            HubConnection con = new HubConnection("https://localhost:44384/");

            // create proxy 
            IHubProxy proxy = con.CreateHubProxy("chatHub");

            // start connection
            con.Start();

            proxy.On<string, string>("newMessage", (clientName, Message) => messages.Invoke(new Action(() => messages.Items.Add(clientName + " : " + Message))));
        }


    }
}
