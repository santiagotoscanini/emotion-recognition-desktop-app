using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class EntityFrameworkIntegrationTest
    {
        protected Context DbContext;

        protected TransactionScope TransactionScope;

        [TestInitialize]
        public void TestSetup()
        {
            DbContext = new MyDbContext(TestInit.TestDatabaseName);
            DbContext.Database.CreateIfNotExists();
            TransactionScope = new TransactionScope(TransactionScopeOption.RequiresNew);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TransactionScope.Dispose();
        }

    }
}
