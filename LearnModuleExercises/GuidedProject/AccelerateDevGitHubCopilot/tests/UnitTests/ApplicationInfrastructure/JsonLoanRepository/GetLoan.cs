using System.Collections.Generic;
using NSubstitute;
using Microsoft.Extensions.Configuration;
using Library.Infrastructure.Data;
using Library.ApplicationCore;

namespace Library.UnitTests.Infrastructure.JsonLoanRepositoryTests;

public class GetLoanTest
{
    private readonly ILoanRepository _mockLoanRepository;
    private readonly JsonLoanRepository _jsonLoanRepository;
    private readonly IConfiguration _configuration;
    private readonly JsonData _jsonData;

    public GetLoanTest()
    {
        // create a simple IConfiguration that JsonData can consume (will fall back to defaults in JsonData if keys missing)
        _configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string>())
            .Build();

        // instantiate JsonData and the repository under test
        _jsonData = new JsonData(_configuration);
        _jsonLoanRepository = new JsonLoanRepository(_jsonData);

        // keep a mock repository available for other tests if needed
        _mockLoanRepository = Substitute.For<ILoanRepository>();
    }
}