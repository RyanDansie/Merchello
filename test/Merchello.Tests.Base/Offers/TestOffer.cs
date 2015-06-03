﻿namespace Merchello.Tests.Base.Offers
{
    using global::Umbraco.Core;

    using Merchello.Core.Marketing.Offer;
    using Merchello.Core.Models;
    using Merchello.Core.Models.Interfaces;

    public class TestOffer : OfferBase 
    {
        public TestOffer(IOfferSettings settings)
            : base(settings)
        {
        }

        public override Attempt<IOfferAwardResult<object>> TryToAward(object constrainBy, ICustomerBase customer)
        {
            throw new System.NotImplementedException();
        }
    }
}