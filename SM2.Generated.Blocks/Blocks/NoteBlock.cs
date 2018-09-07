using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class NoteBlock : Block
    {

        public enum BlockInstrument
        {
            Harp,
            Basedrum,
            Snare,
            Hat,
            Bass,
            Flute,
            Bell,
            Guitar,
            Chime,
            Xylophone,
        }

        public enum BlockNote
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
            N16,
            N17,
            N18,
            N19,
            N20,
            N21,
            N22,
            N23,
            N24,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockInstrument Instrument { get; set; }
        public BlockNote Note { get; set; }
        public BlockPowered Powered { get; set; }

        public NoteBlock()
        {
            Instrument = BlockInstrument.Harp;
            Note = BlockNote.N0;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 248;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 249;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 250;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 251;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 252;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 253;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 254;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 255;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 256;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 257;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 258;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 259;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 260;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 261;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 262;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 263;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 264;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 265;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 266;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 267;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 268;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 269;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 270;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 271;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 272;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 273;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 274;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 275;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 276;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 277;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 278;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 279;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 280;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 281;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 282;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 283;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 284;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 285;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 286;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 287;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 288;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 289;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 290;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 291;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 292;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 293;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 294;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 295;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 296;
        if (true
            && Instrument == BlockInstrument.Harp
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 297;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 298;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 299;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 300;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 301;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 302;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 303;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 304;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 305;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 306;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 307;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 308;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 309;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 310;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 311;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 312;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 313;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 314;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 315;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 316;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 317;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 318;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 319;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 320;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 321;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 322;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 323;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 324;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 325;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 326;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 327;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 328;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 329;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 330;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 331;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 332;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 333;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 334;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 335;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 336;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 337;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 338;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 339;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 340;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 341;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 342;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 343;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 344;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 345;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 346;
        if (true
            && Instrument == BlockInstrument.Basedrum
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 347;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 348;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 349;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 350;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 351;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 352;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 353;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 354;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 355;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 356;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 357;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 358;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 359;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 360;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 361;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 362;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 363;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 364;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 365;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 366;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 367;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 368;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 369;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 370;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 371;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 372;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 373;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 374;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 375;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 376;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 377;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 378;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 379;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 380;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 381;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 382;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 383;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 384;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 385;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 386;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 387;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 388;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 389;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 390;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 391;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 392;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 393;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 394;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 395;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 396;
        if (true
            && Instrument == BlockInstrument.Snare
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 397;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 398;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 399;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 400;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 401;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 402;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 403;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 404;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 405;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 406;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 407;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 408;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 409;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 410;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 411;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 412;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 413;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 414;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 415;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 416;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 417;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 418;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 419;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 420;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 421;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 422;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 423;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 424;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 425;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 426;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 427;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 428;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 429;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 430;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 431;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 432;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 433;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 434;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 435;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 436;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 437;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 438;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 439;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 440;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 441;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 442;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 443;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 444;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 445;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 446;
        if (true
            && Instrument == BlockInstrument.Hat
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 447;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 448;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 449;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 450;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 451;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 452;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 453;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 454;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 455;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 456;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 457;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 458;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 459;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 460;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 461;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 462;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 463;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 464;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 465;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 466;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 467;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 468;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 469;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 470;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 471;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 472;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 473;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 474;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 475;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 476;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 477;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 478;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 479;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 480;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 481;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 482;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 483;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 484;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 485;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 486;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 487;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 488;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 489;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 490;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 491;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 492;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 493;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 494;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 495;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 496;
        if (true
            && Instrument == BlockInstrument.Bass
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 497;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 498;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 499;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 500;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 501;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 502;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 503;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 504;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 505;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 506;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 507;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 508;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 509;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 510;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 511;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 512;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 513;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 514;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 515;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 516;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 517;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 518;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 519;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 520;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 521;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 522;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 523;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 524;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 525;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 526;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 527;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 528;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 529;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 530;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 531;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 532;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 533;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 534;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 535;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 536;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 537;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 538;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 539;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 540;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 541;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 542;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 543;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 544;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 545;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 546;
        if (true
            && Instrument == BlockInstrument.Flute
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 547;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 548;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 549;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 550;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 551;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 552;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 553;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 554;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 555;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 556;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 557;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 558;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 559;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 560;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 561;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 562;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 563;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 564;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 565;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 566;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 567;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 568;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 569;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 570;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 571;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 572;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 573;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 574;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 575;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 576;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 577;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 578;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 579;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 580;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 581;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 582;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 583;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 584;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 585;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 586;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 587;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 588;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 589;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 590;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 591;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 592;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 593;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 594;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 595;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 596;
        if (true
            && Instrument == BlockInstrument.Bell
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 597;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 598;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 599;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 600;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 601;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 602;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 603;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 604;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 605;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 606;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 607;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 608;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 609;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 610;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 611;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 612;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 613;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 614;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 615;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 616;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 617;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 618;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 619;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 620;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 621;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 622;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 623;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 624;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 625;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 626;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 627;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 628;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 629;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 630;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 631;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 632;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 633;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 634;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 635;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 636;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 637;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 638;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 639;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 640;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 641;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 642;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 643;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 644;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 645;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 646;
        if (true
            && Instrument == BlockInstrument.Guitar
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 647;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 648;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 649;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 650;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 651;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 652;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 653;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 654;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 655;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 656;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 657;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 658;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 659;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 660;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 661;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 662;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 663;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 664;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 665;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 666;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 667;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 668;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 669;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 670;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 671;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 672;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 673;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 674;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 675;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 676;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 677;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 678;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 679;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 680;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 681;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 682;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 683;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 684;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 685;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 686;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 687;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 688;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 689;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 690;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 691;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 692;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 693;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 694;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 695;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 696;
        if (true
            && Instrument == BlockInstrument.Chime
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 697;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N0
            && Powered == BlockPowered.True
        )
            return 698;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N0
            && Powered == BlockPowered.False
        )
            return 699;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N1
            && Powered == BlockPowered.True
        )
            return 700;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N1
            && Powered == BlockPowered.False
        )
            return 701;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N2
            && Powered == BlockPowered.True
        )
            return 702;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N2
            && Powered == BlockPowered.False
        )
            return 703;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N3
            && Powered == BlockPowered.True
        )
            return 704;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N3
            && Powered == BlockPowered.False
        )
            return 705;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N4
            && Powered == BlockPowered.True
        )
            return 706;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N4
            && Powered == BlockPowered.False
        )
            return 707;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N5
            && Powered == BlockPowered.True
        )
            return 708;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N5
            && Powered == BlockPowered.False
        )
            return 709;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N6
            && Powered == BlockPowered.True
        )
            return 710;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N6
            && Powered == BlockPowered.False
        )
            return 711;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N7
            && Powered == BlockPowered.True
        )
            return 712;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N7
            && Powered == BlockPowered.False
        )
            return 713;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N8
            && Powered == BlockPowered.True
        )
            return 714;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N8
            && Powered == BlockPowered.False
        )
            return 715;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N9
            && Powered == BlockPowered.True
        )
            return 716;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N9
            && Powered == BlockPowered.False
        )
            return 717;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N10
            && Powered == BlockPowered.True
        )
            return 718;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N10
            && Powered == BlockPowered.False
        )
            return 719;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N11
            && Powered == BlockPowered.True
        )
            return 720;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N11
            && Powered == BlockPowered.False
        )
            return 721;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N12
            && Powered == BlockPowered.True
        )
            return 722;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N12
            && Powered == BlockPowered.False
        )
            return 723;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N13
            && Powered == BlockPowered.True
        )
            return 724;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N13
            && Powered == BlockPowered.False
        )
            return 725;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N14
            && Powered == BlockPowered.True
        )
            return 726;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N14
            && Powered == BlockPowered.False
        )
            return 727;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N15
            && Powered == BlockPowered.True
        )
            return 728;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N15
            && Powered == BlockPowered.False
        )
            return 729;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N16
            && Powered == BlockPowered.True
        )
            return 730;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N16
            && Powered == BlockPowered.False
        )
            return 731;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N17
            && Powered == BlockPowered.True
        )
            return 732;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N17
            && Powered == BlockPowered.False
        )
            return 733;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N18
            && Powered == BlockPowered.True
        )
            return 734;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N18
            && Powered == BlockPowered.False
        )
            return 735;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N19
            && Powered == BlockPowered.True
        )
            return 736;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N19
            && Powered == BlockPowered.False
        )
            return 737;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N20
            && Powered == BlockPowered.True
        )
            return 738;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N20
            && Powered == BlockPowered.False
        )
            return 739;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N21
            && Powered == BlockPowered.True
        )
            return 740;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N21
            && Powered == BlockPowered.False
        )
            return 741;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N22
            && Powered == BlockPowered.True
        )
            return 742;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N22
            && Powered == BlockPowered.False
        )
            return 743;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N23
            && Powered == BlockPowered.True
        )
            return 744;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N23
            && Powered == BlockPowered.False
        )
            return 745;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N24
            && Powered == BlockPowered.True
        )
            return 746;
        if (true
            && Instrument == BlockInstrument.Xylophone
            && Note == BlockNote.N24
            && Powered == BlockPowered.False
        )
            return 747;
            throw new Exception("This shoud be Impossible");
        }
    }
}
