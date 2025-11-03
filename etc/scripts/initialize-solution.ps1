abp install-libs

cd src/ejada.employees.DbMigrator && dotnet run && cd -



cd src/ejada.employees.Web && dotnet dev-certs https -v -ep openiddict.pfx -p config.auth_server_default_pass_phrase 


exit 0