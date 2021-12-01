namespace Heroes
{
   // esta interfas es para poder testear los logs . si uso debug.log() no lo puedo testear.
        public interface ILog
        {
            public void Log(string message);

            int Count();
            
        }
    }
