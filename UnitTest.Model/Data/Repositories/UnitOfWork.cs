
namespace UnitTest.Model.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UnitOfWork : IDisposable
    {
        private bool disposed = false;
        private DataContext context = new DataContext();

        protected virtual void Dispose (bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
