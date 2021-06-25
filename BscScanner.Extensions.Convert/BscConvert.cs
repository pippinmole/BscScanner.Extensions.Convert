namespace BscScanner.Extensions.Convert {
    public static class BscConvert {
        public static double GweiToBnb(float gwei) {
            return gwei * 0.000000000000000001f;
        }

        public static double GweiToBnb(double gwei) {
            return gwei * 0.000000000000000001f;
        }
        
        public static float BnbToGwei(double gwei) {
            return (float) (gwei / 0.000000000000000001);
        }

        public static float BnbToGwei(float gwei) {
            return (float) (gwei / 0.000000000000000001);
        }
    }
}