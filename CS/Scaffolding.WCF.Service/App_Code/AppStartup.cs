namespace Scaffolding.WCF.Service {
    public static class AppStartup {
        public static void AppInitialize() {
            DevExpress.Internal.DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory();
        }
    }
}