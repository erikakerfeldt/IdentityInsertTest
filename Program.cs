using IdentityInsertTest;

AddCompanyWithEmployeeTest();

static void AddCompanyWithEmployeeTest()
{
    using var context = new EFCoreTestContext();

    var company = new Company
    {
        Id = -1, //Our presentation layer sets Id to -1 for new entities
        Name = "Volvo",
        Employees = new List<Employee>
        {
            new()
            {
                Id = -1, //Our presentation layer sets Id to -1 for new entities
                Name = "PG Goldenhammer"
            }
        }
    };

    context.Company.Add(company);
    context.SaveChanges();
}
