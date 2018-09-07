using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedstoneWire : Block
    {

        public enum BlockEast
        {
            Up,
            Side,
            None,
        }

        public enum BlockNorth
        {
            Up,
            Side,
            None,
        }

        public enum BlockPower
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

        public enum BlockSouth
        {
            Up,
            Side,
            None,
        }

        public enum BlockWest
        {
            Up,
            Side,
            None,
        }
        public BlockEast East { get; set; }
        public BlockNorth North { get; set; }
        public BlockPower Power { get; set; }
        public BlockSouth South { get; set; }
        public BlockWest West { get; set; }

        public RedstoneWire()
        {
            East = BlockEast.None;
            North = BlockNorth.None;
            Power = BlockPower.N0;
            South = BlockSouth.None;
            West = BlockWest.None;
        }

        public override int GetState()
        {
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1753;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1754;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1755;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1756;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1757;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1758;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1759;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1760;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1761;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1762;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1763;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1764;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1765;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1766;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1767;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1768;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1769;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1770;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1771;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1772;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1773;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1774;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1775;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1776;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1777;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1778;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1779;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1780;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1781;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1782;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1783;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1784;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1785;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1786;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1787;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1788;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1789;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1790;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1791;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1792;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1793;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1794;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1795;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1796;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1797;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1798;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1799;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1800;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1801;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1802;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1803;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1804;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1805;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1806;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1807;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1808;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1809;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1810;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1811;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1812;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1813;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1814;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1815;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1816;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1817;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1818;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1819;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1820;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1821;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1822;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1823;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1824;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1825;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1826;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1827;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1828;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1829;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1830;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1831;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1832;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1833;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1834;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1835;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1836;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1837;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1838;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1839;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1840;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1841;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1842;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1843;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1844;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1845;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1846;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1847;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1848;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1849;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1850;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1851;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1852;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1853;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1854;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1855;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1856;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1857;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1858;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1859;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1860;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1861;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1862;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1863;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1864;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1865;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1866;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1867;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1868;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1869;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1870;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1871;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1872;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1873;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1874;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1875;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1876;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1877;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1878;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1879;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1880;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1881;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1882;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1883;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1884;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1885;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1886;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1887;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1888;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1889;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1890;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1891;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1892;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1893;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1894;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1895;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1896;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1897;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1898;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1899;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1900;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1901;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1902;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1903;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1904;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1905;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1906;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1907;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1908;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1909;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1910;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1911;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1912;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1913;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1914;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1915;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1916;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1917;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1918;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1919;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1920;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1921;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1922;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1923;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1924;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1925;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1926;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1927;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1928;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1929;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1930;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1931;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1932;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1933;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1934;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1935;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1936;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1937;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1938;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1939;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1940;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1941;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1942;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1943;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1944;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1945;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1946;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1947;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1948;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1949;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1950;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1951;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1952;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1953;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1954;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1955;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1956;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1957;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1958;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1959;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1960;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1961;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1962;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1963;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1964;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1965;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1966;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1967;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1968;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1969;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1970;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1971;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1972;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1973;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1974;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1975;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1976;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1977;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1978;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1979;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1980;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1981;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1982;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1983;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1984;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1985;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1986;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1987;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1988;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1989;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1990;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 1991;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 1992;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 1993;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 1994;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 1995;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 1996;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 1997;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 1998;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 1999;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2000;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2001;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2002;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2003;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2004;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2005;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2006;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2007;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2008;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2009;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2010;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2011;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2012;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2013;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2014;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2015;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2016;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2017;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2018;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2019;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2020;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2021;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2022;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2023;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2024;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2025;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2026;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2027;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2028;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2029;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2030;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2031;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2032;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2033;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2034;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2035;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2036;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2037;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2038;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2039;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2040;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2041;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2042;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2043;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2044;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2045;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2046;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2047;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2048;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2049;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2050;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2051;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2052;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2053;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2054;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2055;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2056;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2057;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2058;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2059;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2060;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2061;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2062;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2063;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2064;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2065;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2066;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2067;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2068;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2069;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2070;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2071;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2072;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2073;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2074;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2075;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2076;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2077;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2078;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2079;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2080;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2081;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2082;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2083;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2084;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2085;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2086;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2087;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2088;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2089;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2090;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2091;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2092;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2093;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2094;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2095;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2096;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2097;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2098;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2099;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2100;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2101;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2102;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2103;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2104;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2105;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2106;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2107;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2108;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2109;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2110;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2111;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2112;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2113;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2114;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2115;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2116;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2117;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2118;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2119;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2120;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2121;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2122;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2123;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2124;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2125;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2126;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2127;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2128;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2129;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2130;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2131;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2132;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2133;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2134;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2135;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2136;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2137;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2138;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2139;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2140;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2141;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2142;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2143;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2144;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2145;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2146;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2147;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2148;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2149;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2150;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2151;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2152;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2153;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2154;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2155;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2156;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2157;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2158;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2159;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2160;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2161;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2162;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2163;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2164;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2165;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2166;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2167;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2168;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2169;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2170;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2171;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2172;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2173;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2174;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2175;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2176;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2177;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2178;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2179;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2180;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2181;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2182;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2183;
        if (true
            && East == BlockEast.Up
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2184;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2185;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2186;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2187;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2188;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2189;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2190;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2191;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2192;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2193;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2194;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2195;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2196;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2197;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2198;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2199;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2200;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2201;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2202;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2203;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2204;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2205;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2206;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2207;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2208;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2209;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2210;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2211;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2212;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2213;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2214;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2215;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2216;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2217;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2218;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2219;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2220;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2221;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2222;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2223;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2224;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2225;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2226;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2227;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2228;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2229;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2230;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2231;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2232;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2233;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2234;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2235;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2236;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2237;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2238;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2239;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2240;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2241;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2242;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2243;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2244;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2245;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2246;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2247;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2248;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2249;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2250;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2251;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2252;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2253;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2254;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2255;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2256;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2257;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2258;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2259;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2260;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2261;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2262;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2263;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2264;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2265;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2266;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2267;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2268;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2269;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2270;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2271;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2272;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2273;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2274;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2275;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2276;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2277;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2278;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2279;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2280;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2281;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2282;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2283;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2284;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2285;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2286;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2287;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2288;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2289;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2290;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2291;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2292;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2293;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2294;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2295;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2296;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2297;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2298;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2299;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2300;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2301;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2302;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2303;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2304;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2305;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2306;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2307;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2308;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2309;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2310;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2311;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2312;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2313;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2314;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2315;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2316;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2317;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2318;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2319;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2320;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2321;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2322;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2323;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2324;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2325;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2326;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2327;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2328;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2329;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2330;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2331;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2332;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2333;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2334;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2335;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2336;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2337;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2338;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2339;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2340;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2341;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2342;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2343;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2344;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2345;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2346;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2347;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2348;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2349;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2350;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2351;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2352;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2353;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2354;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2355;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2356;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2357;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2358;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2359;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2360;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2361;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2362;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2363;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2364;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2365;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2366;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2367;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2368;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2369;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2370;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2371;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2372;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2373;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2374;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2375;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2376;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2377;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2378;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2379;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2380;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2381;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2382;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2383;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2384;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2385;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2386;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2387;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2388;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2389;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2390;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2391;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2392;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2393;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2394;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2395;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2396;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2397;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2398;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2399;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2400;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2401;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2402;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2403;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2404;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2405;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2406;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2407;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2408;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2409;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2410;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2411;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2412;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2413;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2414;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2415;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2416;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2417;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2418;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2419;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2420;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2421;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2422;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2423;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2424;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2425;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2426;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2427;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2428;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2429;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2430;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2431;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2432;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2433;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2434;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2435;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2436;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2437;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2438;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2439;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2440;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2441;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2442;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2443;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2444;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2445;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2446;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2447;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2448;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2449;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2450;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2451;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2452;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2453;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2454;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2455;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2456;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2457;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2458;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2459;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2460;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2461;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2462;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2463;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2464;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2465;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2466;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2467;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2468;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2469;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2470;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2471;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2472;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2473;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2474;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2475;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2476;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2477;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2478;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2479;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2480;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2481;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2482;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2483;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2484;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2485;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2486;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2487;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2488;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2489;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2490;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2491;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2492;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2493;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2494;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2495;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2496;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2497;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2498;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2499;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2500;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2501;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2502;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2503;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2504;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2505;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2506;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2507;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2508;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2509;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2510;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2511;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2512;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2513;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2514;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2515;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2516;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2517;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2518;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2519;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2520;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2521;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2522;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2523;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2524;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2525;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2526;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2527;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2528;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2529;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2530;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2531;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2532;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2533;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2534;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2535;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2536;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2537;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2538;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2539;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2540;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2541;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2542;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2543;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2544;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2545;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2546;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2547;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2548;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2549;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2550;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2551;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2552;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2553;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2554;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2555;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2556;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2557;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2558;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2559;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2560;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2561;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2562;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2563;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2564;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2565;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2566;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2567;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2568;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2569;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2570;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2571;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2572;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2573;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2574;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2575;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2576;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2577;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2578;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2579;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2580;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2581;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2582;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2583;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2584;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2585;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2586;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2587;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2588;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2589;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2590;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2591;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2592;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2593;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2594;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2595;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2596;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2597;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2598;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2599;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2600;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2601;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2602;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2603;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2604;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2605;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2606;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2607;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2608;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2609;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2610;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2611;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2612;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2613;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2614;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2615;
        if (true
            && East == BlockEast.Side
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2616;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2617;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2618;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2619;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2620;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2621;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2622;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2623;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2624;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2625;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2626;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2627;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2628;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2629;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2630;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2631;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2632;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2633;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2634;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2635;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2636;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2637;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2638;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2639;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2640;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2641;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2642;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2643;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2644;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2645;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2646;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2647;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2648;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2649;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2650;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2651;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2652;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2653;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2654;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2655;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2656;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2657;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2658;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2659;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2660;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2661;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2662;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2663;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2664;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2665;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2666;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2667;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2668;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2669;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2670;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2671;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2672;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2673;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2674;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2675;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2676;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2677;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2678;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2679;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2680;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2681;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2682;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2683;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2684;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2685;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2686;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2687;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2688;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2689;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2690;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2691;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2692;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2693;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2694;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2695;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2696;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2697;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2698;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2699;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2700;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2701;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2702;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2703;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2704;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2705;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2706;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2707;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2708;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2709;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2710;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2711;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2712;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2713;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2714;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2715;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2716;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2717;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2718;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2719;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2720;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2721;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2722;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2723;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2724;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2725;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2726;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2727;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2728;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2729;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2730;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2731;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2732;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2733;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2734;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2735;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2736;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2737;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2738;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2739;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2740;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2741;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2742;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2743;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2744;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2745;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2746;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2747;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2748;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2749;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2750;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2751;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2752;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2753;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2754;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2755;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2756;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2757;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2758;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2759;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Up
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2760;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2761;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2762;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2763;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2764;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2765;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2766;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2767;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2768;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2769;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2770;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2771;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2772;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2773;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2774;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2775;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2776;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2777;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2778;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2779;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2780;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2781;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2782;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2783;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2784;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2785;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2786;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2787;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2788;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2789;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2790;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2791;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2792;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2793;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2794;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2795;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2796;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2797;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2798;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2799;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2800;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2801;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2802;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2803;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2804;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2805;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2806;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2807;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2808;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2809;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2810;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2811;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2812;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2813;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2814;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2815;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2816;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2817;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2818;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2819;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2820;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2821;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2822;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2823;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2824;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2825;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2826;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2827;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2828;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2829;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2830;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2831;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2832;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2833;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2834;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2835;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2836;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2837;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2838;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2839;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2840;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2841;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2842;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2843;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2844;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2845;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2846;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2847;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2848;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2849;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2850;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2851;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2852;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2853;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2854;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2855;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2856;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2857;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2858;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2859;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2860;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2861;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2862;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2863;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2864;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2865;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2866;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2867;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2868;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2869;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2870;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2871;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2872;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2873;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2874;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2875;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2876;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2877;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2878;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2879;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2880;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2881;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2882;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2883;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2884;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2885;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2886;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2887;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2888;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2889;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2890;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2891;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2892;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2893;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2894;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2895;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2896;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2897;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2898;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2899;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2900;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2901;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2902;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2903;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.Side
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2904;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2905;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2906;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2907;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2908;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2909;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2910;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2911;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2912;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N0
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2913;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2914;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2915;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2916;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2917;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2918;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2919;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2920;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2921;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N1
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2922;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2923;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2924;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2925;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2926;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2927;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2928;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2929;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2930;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N2
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2931;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2932;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2933;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2934;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2935;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2936;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2937;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2938;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2939;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N3
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2940;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2941;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2942;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2943;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2944;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2945;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2946;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2947;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2948;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N4
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2949;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2950;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2951;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2952;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2953;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2954;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2955;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2956;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2957;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N5
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2958;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2959;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2960;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2961;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2962;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2963;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2964;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2965;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2966;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N6
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2967;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2968;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2969;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2970;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2971;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2972;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2973;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2974;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2975;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N7
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2976;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2977;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2978;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2979;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2980;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2981;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2982;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2983;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2984;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N8
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2985;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2986;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2987;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2988;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2989;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2990;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 2991;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 2992;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 2993;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N9
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 2994;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 2995;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 2996;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 2997;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 2998;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 2999;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 3000;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 3001;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 3002;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N10
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 3003;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 3004;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 3005;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 3006;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 3007;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 3008;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 3009;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 3010;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 3011;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N11
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 3012;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 3013;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 3014;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 3015;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 3016;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 3017;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 3018;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 3019;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 3020;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N12
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 3021;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 3022;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 3023;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 3024;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 3025;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 3026;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 3027;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 3028;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 3029;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N13
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 3030;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 3031;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 3032;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 3033;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 3034;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 3035;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 3036;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 3037;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 3038;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N14
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 3039;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Up
        )
            return 3040;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.Side
        )
            return 3041;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Up
            && West == BlockWest.None
        )
            return 3042;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Up
        )
            return 3043;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.Side
        )
            return 3044;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.Side
            && West == BlockWest.None
        )
            return 3045;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Up
        )
            return 3046;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.Side
        )
            return 3047;
        if (true
            && East == BlockEast.None
            && North == BlockNorth.None
            && Power == BlockPower.N15
            && South == BlockSouth.None
            && West == BlockWest.None
        )
            return 3048;
            throw new Exception("This shoud be Impossible");
        }
    }
}
