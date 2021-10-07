using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page11
{
    class Program
    {
        class DisposerTester : IDisposable
        {
            public string Name { get; set; }
            public void Dispose()
            {
                Console.WriteLine($"Disposing all the resources of the Test object {Name}");
            }
        }

        class DisposerPatternTester : IDisposable
        {
            private bool disposedValue;
            public string Name { get; set; }
            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        Console.WriteLine($"Disposing all the (managed) resources of the Test object {Name}");
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                    Console.WriteLine($"Disposing all the (unmanaged) resources of the Test object {Name}");
                    // TODO: set large fields to null
                    disposedValue = true;
                }
            }

            // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
            ~DisposerPatternTester()
            {
                // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
                Console.WriteLine($"Destructor/Finalizer called on the Test object {Name}");
                Dispose(disposing: false);
            }

            public void Dispose()
            {
                // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
                Console.WriteLine($"Dispose() called on the Test object {Name}");
                Dispose(disposing: true);
                Console.WriteLine($"Suppressing the finalizer on the Test object {Name}");
                GC.SuppressFinalize(this);
            }
        }


        public static void Main()
        {
            // code needed to insure all destructors are called....
            // workaround needed for lecture to be more compelling
            // not typically needed in production
            work();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public static void work()
        {
            DisposerTester dt1 = new DisposerTester() { Name = "DT1: Dispose not Called" };
            DisposerTester dt2 = new DisposerTester() { Name = "DT2: Dispose Called" };
           

            DisposerPatternTester dp1 = new DisposerPatternTester() { Name = "DP1: Dispose not Called" };
            DisposerPatternTester dp2 = new DisposerPatternTester() { Name = "DP2: Dispose Called" };
          


            Console.WriteLine("Work starting...");
            dt2.Dispose();
            dp2.Dispose();
            using (DisposerTester dt3 = new DisposerTester() { Name = "DT3: using statment" })
            {
                Console.WriteLine("Using for dt3 starting(have access to dt3 now...)");
                Console.WriteLine("Using for dt3 exiting...");
            }
            Console.WriteLine("in work between usings...");
            using (DisposerPatternTester dp3 = new DisposerPatternTester() { Name = "DP3: using statement" })
            {
                Console.WriteLine("Using for dp3 starting (have access to dp3 now...)");
                Console.WriteLine("Using for dp3 exiting...");
            }

            Console.WriteLine("Work ending...");



        }
    }
}
