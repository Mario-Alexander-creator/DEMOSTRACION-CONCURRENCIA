using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_11_Demostracion_Concurrencia
{
    public partial class FrmColaImprecion : Form
    {
        private int contador = 0; // Contador de trabajos completados
        private object bloqueo = new(); // Objeto para sincronización
        private SemaphoreSlim semaforo = new SemaphoreSlim(2); // Permite procesar hasta 2 trabajos a la vez
        private Queue<string> colaImpresion = new Queue<string>(); // Cola de trabajos de impresión

        public FrmColaImprecion()
        {
            InitializeComponent();
        }

        private void BtnAgregarTrabajo_Click_1(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    string trabajo = $"Trabajo {DateTime.Now:HH:mm:ss}";
                    colaImpresion.Enqueue(trabajo); // Agrega un trabajo a la cola
                    ActualizarResultado($"Trabajo agregado: {trabajo}");
                    Monitor.Pulse(bloqueo); // Notifica a los procesos en espera
                }
            });
        }

        private void BtnProcesarCola_Click_1(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                while (true)
                {
                    string trabajo = null;

                    lock (bloqueo)
                    {
                        while (colaImpresion.Count == 0)
                        {
                            ActualizarResultado("Esperando trabajos...");
                            Monitor.Wait(bloqueo); // Espera hasta que haya trabajos en la cola
                        }

                        trabajo = colaImpresion.Dequeue(); // Extrae un trabajo de la cola
                    }

                    if (trabajo != null)
                    {
                        ProcesarTrabajo(trabajo); // Procesa el trabajo de impresión
                    }
                }
            });
        }

        private void ProcesarTrabajo(string trabajo)
        {
            semaforo.Wait(); // Limita los trabajos concurrentes
            try
            {
                ActualizarResultado($"Procesando: {trabajo}");
                Thread.Sleep(1000); // Simula el tiempo de impresión
                ActualizarResultado($"Completado: {trabajo}");

                lock (bloqueo)
                {
                    contador++;
                    this.Invoke((MethodInvoker)delegate
                    {
                        LblContador.Text = contador.ToString();
                    });
                }
            }
            finally
            {
                semaforo.Release(); // Libera el semáforo
            }
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultadoImprecion.AppendText($"{DateTime.Now:HH:mm:ss.fff}: {mensaje}{Environment.NewLine}");
        }

       
    }
}  