dotnet clean TechAssigment/TechAssigment.sln
dotnet restore TechAssigment/TechAssigment.sln
dotnet build TechAssigment/TechAssigment.sln
dotnet test TechAssigment/TechAssigment.sln -l:trx
pause