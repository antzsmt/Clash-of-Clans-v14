﻿namespace ClashofClans.Utilities.LogicMath
{
    public static class LogicELOMath
    {
        public static readonly int[] WIN_CHANCE_TABLE =
        {
            9968, 9968, 9968, 9967, 9967, 9967, 9967, 9967, 9966, 9966, 9966, 9966, 9966, 9966, 9965, 9965, 9965, 9965, 9965, 9964, 9964, 9964, 9964, 9964, 9963, 9963, 9963, 9963,
            9962, 9962, 9962, 9962, 9962, 9961, 9961, 9961, 9961, 9961, 9960, 9960, 9960, 9960, 9959, 9959, 9959, 9959, 9958, 9958, 9958, 9958, 9958, 9957, 9957, 9957, 9957, 9956,
            9956, 9956, 9956, 9955, 9955, 9955, 9955, 9954, 9954, 9954, 9953, 9953, 9953, 9953, 9952, 9952, 9952, 9952, 9951, 9951, 9951, 9950, 9950, 9950, 9950, 9949, 9949, 9949,
            9948, 9948, 9948, 9948, 9947, 9947, 9947, 9946, 9946, 9946, 9945, 9945, 9945, 9945, 9944, 9944, 9944, 9943, 9943, 9943, 9942, 9942, 9942, 9941, 9941, 9941, 9940, 9940,
            9940, 9939, 9939, 9939, 9938, 9938, 9938, 9937, 9937, 9936, 9936, 9936, 9935, 9935, 9935, 9934, 9934, 9933, 9933, 9933, 9932, 9932, 9932, 9931, 9931, 9930, 9930, 9930,
            9929, 9929, 9928, 9928, 9928, 9927, 9927, 9926, 9926, 9925, 9925, 9925, 9924, 9924, 9923, 9923, 9922, 9922, 9922, 9921, 9921, 9920, 9920, 9919, 9919, 9918, 9918, 9917,
            9917, 9917, 9916, 9916, 9915, 9915, 9914, 9914, 9913, 9913, 9912, 9912, 9911, 9911, 9910, 9910, 9909, 9909, 9908, 9908, 9907, 9907, 9906, 9905, 9905, 9904, 9904, 9903,
            9903, 9902, 9902, 9901, 9900, 9900, 9899, 9899, 9898, 9898, 9897, 9896, 9896, 9895, 9895, 9894, 9893, 9893, 9892, 9892, 9891, 9890, 9890, 9889, 9889, 9888, 9887, 9887,
            9886, 9885, 9885, 9884, 9883, 9883, 9882, 9881, 9881, 9880, 9879, 9879, 9878, 9877, 9877, 9876, 9875, 9874, 9874, 9873, 9872, 9872, 9871, 9870, 9869, 9869, 9868, 9867,
            9866, 9866, 9865, 9864, 9863, 9863, 9862, 9861, 9860, 9859, 9859, 9858, 9857, 9856, 9855, 9855, 9854, 9853, 9852, 9851, 9850, 9850, 9849, 9848, 9847, 9846, 9845, 9844,
            9843, 9843, 9842, 9841, 9840, 9839, 9838, 9837, 9836, 9835, 9834, 9833, 9833, 9832, 9831, 9830, 9829, 9828, 9827, 9826, 9825, 9824, 9823, 9822, 9821, 9820, 9819, 9818,
            9817, 9816, 9815, 9814, 9813, 9811, 9810, 9809, 9808, 9807, 9806, 9805, 9804, 9803, 9802, 9801, 9799, 9798, 9797, 9796, 9795, 9794, 9793, 9791, 9790, 9789, 9788, 9787,
            9785, 9784, 9783, 9782, 9781, 9779, 9778, 9777, 9776, 9774, 9773, 9772, 9770, 9769, 9768, 9767, 9765, 9764, 9763, 9761, 9760, 9759, 9757, 9756, 9754, 9753, 9752, 9750,
            9749, 9747, 9746, 9745, 9743, 9742, 9740, 9739, 9737, 9736, 9734, 9733, 9731, 9730, 9728, 9727, 9725, 9724, 9722, 9721, 9719, 9718, 9716, 9714, 9713, 9711, 9710, 9708,
            9706, 9705, 9703, 9701, 9700, 9698, 9696, 9695, 9693, 9691, 9690, 9688, 9686, 9684, 9683, 9681, 9679, 9677, 9675, 9674, 9672, 9670, 9668, 9666, 9664, 9663, 9661, 9659,
            9657, 9655, 9653, 9651, 9649, 9647, 9645, 9643, 9641, 9639, 9637, 9635, 9633, 9631, 9629, 9627, 9625, 9623, 9621, 9619, 9617, 9615, 9612, 9610, 9608, 9606, 9604, 9602,
            9599, 9597, 9595, 9593, 9590, 9588, 9586, 9584, 9581, 9579, 9577, 9574, 9572, 9570, 9567, 9565, 9562, 9560, 9558, 9555, 9553, 9550, 9548, 9545, 9543, 9540, 9538, 9535,
            9533, 9530, 9527, 9525, 9522, 9520, 9517, 9514, 9512, 9509, 9506, 9504, 9501, 9498, 9495, 9493, 9490, 9487, 9484, 9481, 9479, 9476, 9473, 9470, 9467, 9464, 9461, 9458,
            9455, 9452, 9449, 9446, 9443, 9440, 9437, 9434, 9431, 9428, 9425, 9422, 9419, 9416, 9412, 9409, 9406, 9403, 9400, 9396, 9393, 9390, 9386, 9383, 9380, 9376, 9373, 9370,
            9366, 9363, 9359, 9356, 9352, 9349, 9345, 9342, 9338, 9335, 9331, 9328, 9324, 9320, 9317, 9313, 9309, 9306, 9302, 9298, 9294, 9291, 9287, 9283, 9279, 9275, 9271, 9268,
            9264, 9260, 9256, 9252, 9248, 9244, 9240, 9236, 9232, 9228, 9223, 9219, 9215, 9211, 9207, 9203, 9198, 9194, 9190, 9185, 9181, 9177, 9172, 9168, 9164, 9159, 9155, 9150,
            9146, 9141, 9137, 9132, 9128, 9123, 9119, 9114, 9109, 9105, 9100, 9095, 9090, 9086, 9081, 9076, 9071, 9066, 9061, 9057, 9052, 9047, 9042, 9037, 9032, 9027, 9022, 9016,
            9011, 9006, 9001, 8996, 8991, 8985, 8980, 8975, 8970, 8964, 8959, 8954, 8948, 8943, 8937, 8932, 8926, 8921, 8915, 8910, 8904, 8898, 8893, 8887, 8881, 8876, 8870, 8864,
            8858, 8852, 8847, 8841, 8835, 8829, 8823, 8817, 8811, 8805, 8799, 8793, 8787, 8780, 8774, 8768, 8762, 8756, 8749, 8743, 8737, 8730, 8724, 8717, 8711, 8705, 8698, 8691,
            8685, 8678, 8672, 8665, 8658, 8652, 8645, 8638, 8631, 8625, 8618, 8611, 8604, 8597, 8590, 8583, 8576, 8569, 8562, 8555, 8548, 8541, 8533, 8526, 8519, 8512, 8504, 8497,
            8490, 8482, 8475, 8467, 8460, 8452, 8445, 8437, 8430, 8422, 8414, 8407, 8399, 8391, 8383, 8376, 8368, 8360, 8352, 8344, 8336, 8328, 8320, 8312, 8304, 8296, 8288, 8279,
            8271, 8263, 8255, 8246, 8238, 8230, 8221, 8213, 8204, 8196, 8187, 8179, 8170, 8162, 8153, 8144, 8136, 8127, 8118, 8109, 8100, 8092, 8083, 8074, 8065, 8056, 8047, 8038,
            8029, 8019, 8010, 8001, 7992, 7983, 7973, 7964, 7955, 7945, 7936, 7926, 7917, 7907, 7898, 7888, 7879, 7869, 7859, 7850, 7840, 7830, 7820, 7811, 7801, 7791, 7781, 7771,
            7761, 7751, 7741, 7731, 7721, 7711, 7700, 7690, 7680, 7670, 7659, 7649, 7639, 7628, 7618, 7607, 7597, 7586, 7576, 7565, 7555, 7544, 7533, 7523, 7512, 7501, 7490, 7479,
            7469, 7458, 7447, 7436, 7425, 7414, 7403, 7392, 7381, 7369, 7358, 7347, 7336, 7325, 7313, 7302, 7291, 7279, 7268, 7256, 7245, 7233, 7222, 7210, 7199, 7187, 7175, 7164,
            7152, 7140, 7129, 7117, 7105, 7093, 7081, 7069, 7057, 7045, 7033, 7021, 7009, 6997, 6985, 6973, 6961, 6949, 6936, 6924, 6912, 6900, 6887, 6875, 6863, 6850, 6838, 6825,
            6813, 6800, 6788, 6775, 6763, 6750, 6737, 6725, 6712, 6699, 6686, 6674, 6661, 6648, 6635, 6622, 6609, 6597, 6584, 6571, 6558, 6545, 6532, 6519, 6506, 6492, 6479, 6466,
            6453, 6440, 6427, 6413, 6400, 6387, 6374, 6360, 6347, 6334, 6320, 6307, 6293, 6280, 6266, 6253, 6240, 6226, 6212, 6199, 6185, 6172, 6158, 6145, 6131, 6117, 6104, 6090,
            6076, 6062, 6049, 6035, 6021, 6007, 5993, 5980, 5966, 5952, 5938, 5924, 5910, 5896, 5882, 5868, 5854, 5841, 5827, 5813, 5798, 5784, 5770, 5756, 5742, 5728, 5714, 5700,
            5686, 5672, 5658, 5644, 5629, 5615, 5601, 5587, 5573, 5558, 5544, 5530, 5516, 5501, 5487, 5473, 5459, 5444, 5430, 5416, 5402, 5387, 5373, 5359, 5344, 5330, 5316, 5301,
            5287, 5273, 5258, 5244, 5230, 5215, 5201, 5186, 5172, 5158, 5143, 5129, 5115, 5100, 5086, 5071, 5057, 5043, 5028, 5014, 5000, 4985, 4971, 4956, 4942, 4928, 4913, 4899,
            4884, 4870, 4856, 4841, 4827, 4813, 4798, 4784, 4769, 4755, 4741, 4726, 4712, 4698, 4683, 4669, 4655, 4640, 4626, 4612, 4597, 4583, 4569, 4555, 4540, 4526, 4512, 4498,
            4483, 4469, 4455, 4441, 4426, 4412, 4398, 4384, 4370, 4355, 4341, 4327, 4313, 4299, 4285, 4271, 4257, 4243, 4229, 4215, 4201, 4186, 4172, 4158, 4145, 4131, 4117, 4103,
            4089, 4075, 4061, 4047, 4033, 4019, 4006, 3992, 3978, 3964, 3950, 3937, 3923, 3909, 3895, 3882, 3868, 3854, 3841, 3827, 3814, 3800, 3787, 3773, 3759, 3746, 3733, 3719,
            3706, 3692, 3679, 3665, 3652, 3639, 3625, 3612, 3599, 3586, 3572, 3559, 3546, 3533, 3520, 3507, 3493, 3480, 3467, 3454, 3441, 3428, 3415, 3402, 3390, 3377, 3364, 3351,
            3338, 3325, 3313, 3300, 3287, 3274, 3262, 3249, 3236, 3224, 3211, 3199, 3186, 3174, 3161, 3149, 3136, 3124, 3112, 3099, 3087, 3075, 3063, 3050, 3038, 3026, 3014, 3002,
            2990, 2978, 2966, 2954, 2942, 2930, 2918, 2906, 2894, 2882, 2870, 2859, 2847, 2835, 2824, 2812, 2800, 2789, 2777, 2766, 2754, 2743, 2731, 2720, 2708, 2697, 2686, 2674,
            2663, 2652, 2641, 2630, 2618, 2607, 2596, 2585, 2574, 2563, 2552, 2541, 2530, 2520, 2509, 2498, 2487, 2476, 2466, 2455, 2444, 2434, 2423, 2413, 2402, 2392, 2381, 2371,
            2360, 2350, 2340, 2329, 2319, 2309, 2299, 2288, 2278, 2268, 2258, 2248, 2238, 2228, 2218, 2208, 2198, 2188, 2179, 2169, 2159, 2149, 2140, 2130, 2120, 2111, 2101, 2092,
            2082, 2073, 2063, 2054, 2044, 2035, 2026, 2016, 2007, 1998, 1989, 1980, 1970, 1961, 1952, 1943, 1934, 1925, 1916, 1907, 1899, 1890, 1881, 1872, 1863, 1855, 1846, 1837,
            1829, 1820, 1812, 1803, 1795, 1786, 1778, 1769, 1761, 1753, 1744, 1736, 1728, 1720, 1711, 1703, 1695, 1687, 1679, 1671, 1663, 1655, 1647, 1639, 1631, 1623, 1616, 1608,
            1600, 1592, 1585, 1577, 1569, 1562, 1554, 1547, 1539, 1532, 1524, 1517, 1509, 1502, 1495, 1487, 1480, 1473, 1466, 1458, 1451, 1444, 1437, 1430, 1423, 1416, 1409, 1402,
            1395, 1388, 1381, 1374, 1368, 1361, 1354, 1347, 1341, 1334, 1327, 1321, 1314, 1308, 1301, 1294, 1288, 1282, 1275, 1269, 1262, 1256, 1250, 1243, 1237, 1231, 1225, 1219,
            1212, 1206, 1200, 1194, 1188, 1182, 1176, 1170, 1164, 1158, 1152, 1147, 1141, 1135, 1129, 1123, 1118, 1112, 1106, 1101, 1095, 1089, 1084, 1078, 1073, 1067, 1062, 1056,
            1051, 1045, 1040, 1035, 1029, 1024, 1019, 1014, 1008, 1003, 998, 993, 988, 983, 977, 972, 967, 962, 957, 952, 947, 942, 938, 933, 928, 923, 918, 913, 909, 904, 899,
            894, 890, 885, 880, 876, 871, 867, 862, 858, 853, 849, 844, 840, 835, 831, 827, 822, 818, 814, 809, 805, 801, 796, 792, 788, 784, 780, 776, 771, 767, 763, 759, 755,
            751, 747, 743, 739, 735, 731, 728, 724, 720, 716, 712, 708, 705, 701, 697, 693, 690, 686, 682, 679, 675, 671, 668, 664, 661, 657, 654, 650, 647, 643, 640, 636, 633,
            629, 626, 623, 619, 616, 613, 609, 606, 603, 599, 596, 593, 590, 587, 583, 580, 577, 574, 571, 568, 565, 562, 559, 556, 553, 550, 547, 544, 541, 538, 535, 532, 529,
            526, 523, 520, 518, 515, 512, 509, 506, 504, 501, 498, 495, 493, 490, 487, 485, 482, 479, 477, 474, 472, 469, 466, 464, 461, 459, 456, 454, 451, 449, 446, 444, 441,
            439, 437, 434, 432, 429, 427, 425, 422, 420, 418, 415, 413, 411, 409, 406, 404, 402, 400, 397, 395, 393, 391, 389, 387, 384, 382, 380, 378, 376, 374, 372, 370, 368,
            366, 364, 362, 360, 358, 356, 354, 352, 350, 348, 346, 344, 342, 340, 338, 336, 335, 333, 331, 329, 327, 325, 324, 322, 320, 318, 316, 315, 313, 311, 309, 308, 306,
            304, 303, 301, 299, 298, 296, 294, 293, 291, 289, 288, 286, 285, 283, 281, 280, 278, 277, 275, 274, 272, 271, 269, 268, 266, 265, 263, 262, 260, 259, 257, 256, 254,
            253, 252, 250, 249, 247, 246, 245, 243, 242, 240, 239, 238, 236, 235, 234, 232, 231, 230, 229, 227, 226, 225, 223, 222, 221, 220, 218, 217, 216, 215, 214, 212, 211,
            210, 209, 208, 206, 205, 204, 203, 202, 201, 200, 198, 197, 196, 195, 194, 193, 192, 191, 190, 189, 188, 186, 185, 184, 183, 182, 181, 180, 179, 178, 177, 176, 175,
            174, 173, 172, 171, 170, 169, 168, 167, 166, 166, 165, 164, 163, 162, 161, 160, 159, 158, 157, 156, 156, 155, 154, 153, 152, 151, 150, 149, 149, 148, 147, 146, 145,
            144, 144, 143, 142, 141, 140, 140, 139, 138, 137, 136, 136, 135, 134, 133, 133, 132, 131, 130, 130, 129, 128, 127, 127, 126, 125, 125, 124, 123, 122, 122, 121, 120,
            120, 119, 118, 118, 117, 116, 116, 115, 114, 114, 113, 112, 112, 111, 110, 110, 109, 109, 108, 107, 107, 106, 106, 105, 104, 104, 103, 103, 102, 101, 101, 100, 100, 99,
            99, 98, 97, 97, 96, 96, 95, 95, 94, 94, 93, 92, 92, 91, 91, 90, 90, 89, 89, 88, 88, 87, 87, 86, 86, 85, 85, 84, 84, 83, 83, 82, 82, 82, 81, 81, 80, 80, 79, 79, 78, 78,
            77, 77, 77, 76, 76, 75, 75, 74, 74, 74, 73, 73, 72, 72, 71, 71, 71, 70, 70, 69, 69, 69, 68, 68, 67, 67, 67, 66, 66, 66, 65, 65, 64, 64, 64, 63, 63, 63, 62, 62, 61, 61,
            61, 60, 60, 60, 59, 59, 59, 58, 58, 58, 57, 57, 57, 56, 56, 56, 55, 55, 55, 54, 54, 54, 54, 53, 53, 53, 52, 52, 52, 51, 51, 51, 51, 50, 50, 50, 49, 49, 49, 49, 48, 48,
            48, 47, 47, 47, 47, 46, 46, 46, 46, 45, 45, 45, 44, 44, 44, 44, 43, 43, 43, 43, 42, 42, 42, 42, 41, 41, 41, 41, 41, 40, 40, 40, 40, 39, 39, 39, 39, 38, 38, 38, 38, 38,
            37, 37, 37, 37, 37, 36, 36, 36, 36, 35, 35, 35, 35, 35, 34, 34, 34, 34, 34, 33, 33, 33, 33, 33, 33, 32, 32, 32, 32, 32, 31, 31, 31
        };

        public static int CalculateNewRating(bool gain, int attackerScore, int defenderScore, int multiplier)
        {
            int diffScore = defenderScore - attackerScore;
            int winChanceOffset = 0;

            if (diffScore >= -1000)
            {
                winChanceOffset = 2000;

                if (diffScore <= 1000)
                {
                    winChanceOffset = diffScore + 1000;
                }
            }

            return attackerScore + multiplier * ((gain ? 10000 : 0) - LogicELOMath.WIN_CHANCE_TABLE[winChanceOffset]) / 10000;
        }

        public static int CalculateNewRating(bool gain, int attackerScore, int defenderScore, int multiplier, int eloOffsetDampeningFactor, int eloOffsetDampeningLimit,
                                             int eloOffsetDampeningScoreLimit)
        {
            int diffScore = defenderScore - attackerScore;

            if (eloOffsetDampeningFactor > 0 && eloOffsetDampeningLimit > 0 && eloOffsetDampeningScoreLimit > 0)
            {
                diffScore = diffScore * LogicMath.Max(eloOffsetDampeningLimit, 100 - eloOffsetDampeningFactor * (attackerScore + defenderScore) / eloOffsetDampeningScoreLimit) /
                            100;
            }

            int winChanceOffset = 0;

            if (diffScore >= -1000)
            {
                winChanceOffset = diffScore + 1000;

                if (diffScore > 1000)
                {
                    winChanceOffset = 2000;
                }
            }

            return attackerScore + multiplier * ((gain ? 10000 : 0) - LogicELOMath.WIN_CHANCE_TABLE[winChanceOffset]) / 10000;
        }
    }
}
