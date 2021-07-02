using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Work_Service_Template_net_Core.src
{
    class Main
    {
        private Timer _timerIntervaloDaTarefa;
        bool isRunningRelatorio = false;

        public void Start()
        {
            Configura_Timer();
            _timerIntervaloDaTarefa.Start();
        }

        private void Configura_Timer()
        {
            if (_timerIntervaloDaTarefa == null)
            {
                _timerIntervaloDaTarefa = new Timer();
                _timerIntervaloDaTarefa.AutoReset = true;
                _timerIntervaloDaTarefa.Interval = 60000; //1 minuto
                _timerIntervaloDaTarefa.Elapsed += new ElapsedEventHandler(ExecutaTarefa);
            }
        }
        private void ExecutaTarefa(object sender, EventArgs e)
        {
            if (!isRunningRelatorio)
            {
                isRunningRelatorio = true;

                try
                {
                    Console.WriteLine("Executa tarefa.");
                }
                catch (Exception ex)
                {

                    throw;
                }

                isRunningRelatorio = false;
            }
        }
    }
}
