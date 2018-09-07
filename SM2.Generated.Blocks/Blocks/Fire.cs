using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Fire : Block
    {

        public enum BlockAge
        {
            N0,
            N1,
            N2,
            N3,
            N4,
            N5,
            N6,
            N7,
            N8,
            N9,
            N10,
            N11,
            N12,
            N13,
            N14,
            N15,
        }

        public enum BlockEast
        {
            True,
            False,
        }

        public enum BlockNorth
        {
            True,
            False,
        }

        public enum BlockSouth
        {
            True,
            False,
        }

        public enum BlockUp
        {
            True,
            False,
        }

        public enum BlockWest
        {
            True,
            False,
        }
        public BlockAge Age { get; set; }
        public BlockEast East { get; set; }
        public BlockNorth North { get; set; }
        public BlockSouth South { get; set; }
        public BlockUp Up { get; set; }
        public BlockWest West { get; set; }

        public Fire()
        {
            Age = BlockAge.N0;
            East = BlockEast.False;
            North = BlockNorth.False;
            South = BlockSouth.False;
            Up = BlockUp.False;
            West = BlockWest.False;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1136;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1137;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1138;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1139;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1140;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1141;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1142;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1143;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1144;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1145;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1146;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1147;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1148;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1149;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1150;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1151;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1152;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1153;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1154;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1155;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1156;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1157;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1158;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1159;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1160;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1161;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1162;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1163;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1164;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1165;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1166;
        if (true
            && Age == BlockAge.N0
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1167;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1168;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1169;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1170;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1171;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1172;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1173;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1174;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1175;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1176;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1177;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1178;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1179;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1180;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1181;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1182;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1183;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1184;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1185;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1186;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1187;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1188;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1189;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1190;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1191;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1192;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1193;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1194;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1195;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1196;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1197;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1198;
        if (true
            && Age == BlockAge.N1
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1199;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1200;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1201;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1202;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1203;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1204;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1205;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1206;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1207;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1208;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1209;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1210;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1211;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1212;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1213;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1214;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1215;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1216;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1217;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1218;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1219;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1220;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1221;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1222;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1223;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1224;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1225;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1226;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1227;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1228;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1229;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1230;
        if (true
            && Age == BlockAge.N2
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1231;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1232;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1233;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1234;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1235;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1236;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1237;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1238;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1239;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1240;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1241;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1242;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1243;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1244;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1245;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1246;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1247;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1248;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1249;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1250;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1251;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1252;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1253;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1254;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1255;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1256;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1257;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1258;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1259;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1260;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1261;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1262;
        if (true
            && Age == BlockAge.N3
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1263;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1264;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1265;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1266;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1267;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1268;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1269;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1270;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1271;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1272;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1273;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1274;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1275;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1276;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1277;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1278;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1279;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1280;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1281;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1282;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1283;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1284;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1285;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1286;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1287;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1288;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1289;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1290;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1291;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1292;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1293;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1294;
        if (true
            && Age == BlockAge.N4
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1295;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1296;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1297;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1298;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1299;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1300;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1301;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1302;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1303;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1304;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1305;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1306;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1307;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1308;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1309;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1310;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1311;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1312;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1313;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1314;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1315;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1316;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1317;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1318;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1319;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1320;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1321;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1322;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1323;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1324;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1325;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1326;
        if (true
            && Age == BlockAge.N5
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1327;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1328;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1329;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1330;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1331;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1332;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1333;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1334;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1335;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1336;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1337;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1338;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1339;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1340;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1341;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1342;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1343;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1344;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1345;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1346;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1347;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1348;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1349;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1350;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1351;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1352;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1353;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1354;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1355;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1356;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1357;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1358;
        if (true
            && Age == BlockAge.N6
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1359;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1360;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1361;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1362;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1363;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1364;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1365;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1366;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1367;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1368;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1369;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1370;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1371;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1372;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1373;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1374;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1375;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1376;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1377;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1378;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1379;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1380;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1381;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1382;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1383;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1384;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1385;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1386;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1387;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1388;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1389;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1390;
        if (true
            && Age == BlockAge.N7
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1391;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1392;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1393;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1394;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1395;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1396;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1397;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1398;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1399;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1400;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1401;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1402;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1403;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1404;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1405;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1406;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1407;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1408;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1409;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1410;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1411;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1412;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1413;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1414;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1415;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1416;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1417;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1418;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1419;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1420;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1421;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1422;
        if (true
            && Age == BlockAge.N8
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1423;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1424;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1425;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1426;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1427;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1428;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1429;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1430;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1431;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1432;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1433;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1434;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1435;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1436;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1437;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1438;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1439;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1440;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1441;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1442;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1443;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1444;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1445;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1446;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1447;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1448;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1449;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1450;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1451;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1452;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1453;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1454;
        if (true
            && Age == BlockAge.N9
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1455;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1456;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1457;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1458;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1459;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1460;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1461;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1462;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1463;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1464;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1465;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1466;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1467;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1468;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1469;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1470;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1471;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1472;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1473;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1474;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1475;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1476;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1477;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1478;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1479;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1480;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1481;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1482;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1483;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1484;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1485;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1486;
        if (true
            && Age == BlockAge.N10
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1487;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1488;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1489;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1490;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1491;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1492;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1493;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1494;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1495;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1496;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1497;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1498;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1499;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1500;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1501;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1502;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1503;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1504;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1505;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1506;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1507;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1508;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1509;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1510;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1511;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1512;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1513;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1514;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1515;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1516;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1517;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1518;
        if (true
            && Age == BlockAge.N11
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1519;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1520;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1521;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1522;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1523;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1524;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1525;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1526;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1527;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1528;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1529;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1530;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1531;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1532;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1533;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1534;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1535;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1536;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1537;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1538;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1539;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1540;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1541;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1542;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1543;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1544;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1545;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1546;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1547;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1548;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1549;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1550;
        if (true
            && Age == BlockAge.N12
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1551;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1552;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1553;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1554;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1555;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1556;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1557;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1558;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1559;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1560;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1561;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1562;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1563;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1564;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1565;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1566;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1567;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1568;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1569;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1570;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1571;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1572;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1573;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1574;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1575;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1576;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1577;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1578;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1579;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1580;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1581;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1582;
        if (true
            && Age == BlockAge.N13
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1583;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1584;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1585;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1586;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1587;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1588;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1589;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1590;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1591;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1592;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1593;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1594;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1595;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1596;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1597;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1598;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1599;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1600;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1601;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1602;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1603;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1604;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1605;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1606;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1607;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1608;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1609;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1610;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1611;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1612;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1613;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1614;
        if (true
            && Age == BlockAge.N14
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1615;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1616;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1617;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1618;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1619;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1620;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1621;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1622;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1623;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1624;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1625;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1626;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1627;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1628;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1629;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1630;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1631;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1632;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1633;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1634;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1635;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1636;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1637;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1638;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1639;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1640;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1641;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1642;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1643;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 1644;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 1645;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 1646;
        if (true
            && Age == BlockAge.N15
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 1647;
            throw new Exception("This shoud be Impossible");
        }
    }
}
