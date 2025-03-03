using Coin.Coins;
using FlappyBird.Character;
using FlappyBird.Core;
using VContainer;
using VContainer.Unity;

public class BootstrapInstaller : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<GameState>(Lifetime.Singleton);
        builder.Register<Coins>(Lifetime.Singleton);
        builder.RegisterComponentInHierarchy<UI>();
        builder.RegisterComponentInHierarchy<CharacterConfigBase>();
        builder.RegisterComponentInHierarchy<InitCharacter>();
    }
}
