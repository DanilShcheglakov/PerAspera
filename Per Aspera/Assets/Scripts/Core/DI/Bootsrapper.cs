using System;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using YG;

public class Bootsrapper : LifetimeScope
{
    [SerializeField] private ShipCatalog shipCatalog;
    [SerializeField] private RaceCoordinator _raceCoordinator;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<ShipSelector>(Lifetime.Singleton);

        builder.RegisterInstance(shipCatalog);
        builder.RegisterInstance(_raceCoordinator);


        if (YG2.envir.isDesktop)        
            builder.Register<PCInputHandler>(Lifetime.Singleton).As<IInputHandler>();        
        else        
            builder.Register<MobileInputHandler>(Lifetime.Singleton).As<IInputHandler>();
    }
}
