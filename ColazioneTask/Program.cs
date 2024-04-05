using ColazioneTask;

class Program
{
    static void Main(string[] args)
    {
        Piatto piatto = new();
        Cameriere cameriere = new(piatto);
        Cliente cliente = new(piatto);

        Task cameriereTask = Task.Run(() => cameriere.Prepara());
        Task clienteTask = Task.Run(() => cliente.Mangia());

        Task.WaitAll(cameriereTask, clienteTask);
    }
}