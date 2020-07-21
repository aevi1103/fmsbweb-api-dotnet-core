using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;

using FmsbwebCoreApi.Context;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.Services.FMSB2;
using FmsbwebCoreApi.Services.FmsbMvc;
using FmsbwebCoreApi.Services.Intranet;
using FmsbwebCoreApi.Services;

namespace FmsbwebCoreApiTests.Services.SAP
{
    public class SapLibraryRepositoryTest
    {
        //[Fact]
        //public void GetDailyScrapByShift_ParamsIsNull_ThrowsArgumentNullException()
        //{

        //  var mockSapContext = new Mock<SapContext>().Object;
        //  var mockFmsb2Context = new Mock<Fmsb2Context>().Object;
        //  var mockFmsb2Repo = new Mock<IFmsb2LibraryRepository>().Object;
        //  var mockMvcRepo = new Mock<IFmsbMvcLibraryRepository>().Object;
        //  var mockIntranetRepo = new Mock<IIntranetLibraryRepository>().Object;

        //  var mockScrapRepo = new Mock<IScrapRepository>().Object;

        //    var service = new SapLibraryService(mockSapContext, mockFmsb2Context, mockFmsb2Repo, mockMvcRepo, mockIntranetRepo, mockScrapRepo);

        //  Assert.ThrowsAsync<ArgumentNullException>(() => service.GetDailyScrapByShift(null));
        //}
    }
}
