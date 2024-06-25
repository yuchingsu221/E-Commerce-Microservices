using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace YuChingECommerce.Services.AuthAPI.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // 獲取配置
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // 構建 DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

/*
Unable to create a 'DbContext' of type 'YuChingECommerce.Services.AuthAPI.Data.AppDbContext'. The exception 'Unable to resolve service for type 'Microsoft.EntityFrameworkCore.DbContextOptions1[YuChingECommerce.Services.AuthAPI.Data.AppDbContext]' while attempting to activate 'YuChingECommerce.Services.AuthAPI.Data.AppDbContext'.' was thrown while attempting to create an instance. For the different patterns supported at design time, see https://go.microsoft.com/fwlink/?linkid=851728
  
這個錯誤通常是因為在設計時（例如運行 Add-Migration 或 Update-Database 命令時），Entity Framework 無法解析 DbContext 的依賴項。這通常是因為在設計時，DbContext 的依賴注入配置與運行時的配置有所不同。

解決方案：提供 DbContext 的設計時工廠
需要為 DbContext 提供一個設計時工廠（Design-Time Factory），以便在設計時（即運行命令時）正確地創建 DbContext。這可以通過實現 IDesignTimeDbContextFactory<TContext> 接口來實現。
 */

/*
解決步驟
(1) 產生 DbContext 建置工廠
(2) 刪除舊有的或是產生新的 Migration
 PM> Add-Migration AddNewIdentityTables -Context YuChingECommerce.Services.AuthAPI.Data.AppDbContext
 PM> Remove-Migration -Context YuChingECommerce.Services.AuthAPI.Data.AppDbContext
(3) 更新資料庫
 PM> Update-Database -Context YuChingECommerce.Services.AuthAPI.Data.AppDbContext
 */
