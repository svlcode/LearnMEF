using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace LearnMEF
{
    public class HostMefInAnApplication
    {
        private ILogger _logger;

        [Import]
        public ILogger Logger 
        {
            get { return _logger; }
            set { _logger = value; }
        } 

        private  void Compose()
        {
            CompositionContainer container = new CompositionContainer();

            //var batch = new CompositionBatch();
            //batch.AddPart(new SomeRandomLogger());

            //container.Compose(batch);
            container.ComposeParts(this, new SomeRandomLogger());
        }

        public void Run()
        {
            Compose();

            Logger.Write("This is a message.");
        }
    }
}