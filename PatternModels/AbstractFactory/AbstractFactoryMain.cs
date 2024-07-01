using System;

namespace DesignPattern.PatternModels.AbstractFactory
{
    /// <summary>
    /// 抽象工厂模式包含以下几个角色：
    ///     抽象工厂（Abstract Factory）：声明一组创建产品的方法，每个方法对应一个具体产品族。
    ///     具体工厂（Concrete Factory）：实现抽象工厂中的方法，负责创建具体的产品对象。
    ///     抽象产品（Abstract Product）：定义产品的共同接口，具体产品类都实现了这个接口。
    ///     具体产品（Concrete Product）：实现抽象产品接口的具体产品。
    /// </summary>
    internal class AbstractFactoryMain
    {
        private static void Main(string[] args)
        {
            BuildAssetBundleOptions options = BuildAssetBundleOptions.ChunkBasedCompression;
            options |= BuildAssetBundleOptions.DisableWriteTypeTree;
            options |= BuildAssetBundleOptions.ForceRebuildAssetBundle;
            options |= BuildAssetBundleOptions.IgnoreTypeTreeChanges;
            options |= BuildAssetBundleOptions.AppendHashToAssetBundleName;
            options |= BuildAssetBundleOptions.StrictMode;
            options |= BuildAssetBundleOptions.DryRunBuild;
            Console.WriteLine(options);
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
    }

    public enum BuildAssetBundleOptions
    {
        //
        // Summary:
        //     Build assetBundle without any special option.
        None = 0x0,
        //
        // Summary:
        //     Don't compress the data when creating the AssetBundle.
        UncompressedAssetBundle = 0x1,
        //
        // Summary:
        //     Includes all dependencies.
        [Obsolete("This has been made obsolete. It is always enabled in the new AssetBundle build system introduced in 5.0.")]
        CollectDependencies = 0x2,
        //
        // Summary:
        //     Forces inclusion of the entire asset.
        [Obsolete("This has been made obsolete. It is always enabled in the new AssetBundle build system introduced in 5.0.")]
        CompleteAssets = 0x4,
        //
        // Summary:
        //     Do not include type information within the AssetBundle.
        DisableWriteTypeTree = 0x8,
        //
        // Summary:
        //     Builds an asset bundle using a hash for the id of the object stored in the asset
        //     bundle.
        DeterministicAssetBundle = 0x10,
        //
        // Summary:
        //     Force rebuild the assetBundles.
        ForceRebuildAssetBundle = 0x20,
        //
        // Summary:
        //     Ignore the type tree changes when doing the incremental build check.
        IgnoreTypeTreeChanges = 0x40,
        //
        // Summary:
        //     Append the hash to the assetBundle name.
        AppendHashToAssetBundleName = 0x80,
        //
        // Summary:
        //     Use chunk-based LZ4 compression when creating the AssetBundle.
        ChunkBasedCompression = 0x100,
        //
        // Summary:
        //     Do not allow the build to succeed if any errors are reporting during it.
        StrictMode = 0x200,
        //
        // Summary:
        //     Do a dry run build.
        DryRunBuild = 0x400,
        //
        // Summary:
        //     Disables Asset Bundle LoadAsset by file name.
        DisableLoadAssetByFileName = 0x1000,
        //
        // Summary:
        //     Disables Asset Bundle LoadAsset by file name with extension.
        DisableLoadAssetByFileNameWithExtension = 0x2000,
        //
        // Summary:
        //     Removes the Unity Version number in the Archive File & Serialized File headers
        //     during the build.
        AssetBundleStripUnityVersion = 0x8000,
        //
        // Summary:
        //     Enable asset bundle protection.
        EnableProtection = 0x10000
    }
}
