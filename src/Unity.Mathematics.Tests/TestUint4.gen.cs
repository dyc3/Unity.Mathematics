// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint4
    {
        [Test]
        public void uint4_constructor()
        {
            uint4 a = new uint4(1, 2, 3, 4);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
            Assert.AreEqual(a.w, 4);
        }

        [Test]
        public void uint4_scalar_constructor()
        {
            uint4 a = new uint4(17u);
            Assert.AreEqual(a.x, 17u);
            Assert.AreEqual(a.y, 17u);
            Assert.AreEqual(a.z, 17u);
            Assert.AreEqual(a.w, 17u);
        }

        [Test]
        public void uint4_static_constructor()
        {
            uint4 a = uint4(1, 2, 3, 4);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
            Assert.AreEqual(a.w, 4);
        }

        [Test]
        public void uint4_static_scalar_constructor()
        {
            uint4 a = uint4(17u);
            Assert.AreEqual(a.x, 17u);
            Assert.AreEqual(a.y, 17u);
            Assert.AreEqual(a.z, 17u);
            Assert.AreEqual(a.w, 17u);
        }

        [Test]
        public void uint4_operator_equal_wide_wide()
        {
            uint4 a0 = uint4(2105871082, 35218899, 1550755093, 764676020);
            uint4 b0 = uint4(1477587886, 579629692, 540974792, 208405066);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint4 a1 = uint4(606743782, 1208156098, 1023640014, 1038468316);
            uint4 b1 = uint4(2063397938, 1060167409, 362592601, 2097545362);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint4 a2 = uint4(1416064367, 727143393, 2061243891, 184669837);
            uint4 b2 = uint4(277670088, 426944490, 901076223, 857900673);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint4 a3 = uint4(1303661760, 2044073738, 370395888, 1822916805);
            uint4 b3 = uint4(1548779757, 325265488, 312658571, 176373760);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4_operator_equal_wide_scalar()
        {
            uint4 a0 = uint4(437822262, 2020661134, 541786900, 853113810);
            uint b0 = (1332833578);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint4 a1 = uint4(23716499, 1409026299, 948838849, 953202998);
            uint b1 = (179951405);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint4 a2 = uint4(691955848, 1851546137, 712957637, 2028784869);
            uint b2 = (1926262965);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint4 a3 = uint4(1049962241, 1016802970, 390120467, 464814777);
            uint b3 = (1836975611);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4_operator_equal_scalar_wide()
        {
            uint a0 = (542329200);
            uint4 b0 = uint4(1115584594, 684107773, 1928988941, 890709324);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (641152437);
            uint4 b1 = uint4(1410341302, 497505660, 1068223109, 2014009435);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (213835595);
            uint4 b2 = uint4(1592428361, 1819361470, 448650623, 1942175642);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (64377057);
            uint4 b3 = uint4(1485938610, 1146305380, 1312317120, 263290348);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4_operator_not_equal_wide_wide()
        {
            uint4 a0 = uint4(1977284100, 1293292704, 1547283851, 422428953);
            uint4 b0 = uint4(1514195556, 957972049, 507667364, 581861672);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint4 a1 = uint4(195833190, 1711544892, 5606053, 737069074);
            uint4 b1 = uint4(1128094576, 940096636, 57559040, 181752616);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint4 a2 = uint4(647386678, 13079405, 1413841590, 1076166545);
            uint4 b2 = uint4(962017320, 1762015406, 1107218953, 2042026522);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint4 a3 = uint4(1211445174, 1289303469, 1436402489, 1129570126);
            uint4 b3 = uint4(836002288, 570272309, 2112081980, 1500634658);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4_operator_not_equal_wide_scalar()
        {
            uint4 a0 = uint4(1038269360, 1427812625, 103361237, 1347017023);
            uint b0 = (768873026);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint4 a1 = uint4(1523584313, 660334527, 719113717, 262959423);
            uint b1 = (150442802);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint4 a2 = uint4(484398043, 226568494, 507918242, 1702162286);
            uint b2 = (506946952);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint4 a3 = uint4(923269270, 114581840, 1045389187, 1648095254);
            uint b3 = (166187260);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4_operator_not_equal_scalar_wide()
        {
            uint a0 = (1652127596);
            uint4 b0 = uint4(953791238, 271722683, 1278885987, 735128017);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (112416504);
            uint4 b1 = uint4(25967222, 1761444475, 1844594536, 1199122922);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (634219279);
            uint4 b2 = uint4(942501101, 67161343, 969944293, 833229499);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (1304301133);
            uint4 b3 = uint4(704045745, 345012334, 1253134152, 325772538);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4_operator_less_wide_wide()
        {
            uint4 a0 = uint4(1486550609, 1779244308, 1602148045, 1614085440);
            uint4 b0 = uint4(97842578, 536551311, 413528975, 1838293684);
            bool4 r0 = bool4(false, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint4 a1 = uint4(1975613414, 942838342, 1092279031, 373677431);
            uint4 b1 = uint4(1283898480, 1456599961, 1080278602, 529676676);
            bool4 r1 = bool4(false, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint4 a2 = uint4(1419098312, 337757077, 1081797900, 1336745069);
            uint4 b2 = uint4(156584048, 117348799, 246927124, 1916615924);
            bool4 r2 = bool4(false, false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint4 a3 = uint4(840685445, 1220554047, 2013681746, 192965012);
            uint4 b3 = uint4(1731071394, 1328098431, 1014995792, 480319327);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4_operator_less_wide_scalar()
        {
            uint4 a0 = uint4(796797557, 670113454, 933579492, 278884514);
            uint b0 = (746564682);
            bool4 r0 = bool4(false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint4 a1 = uint4(318174822, 741886928, 1990922600, 1030849597);
            uint b1 = (1117630673);
            bool4 r1 = bool4(true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint4 a2 = uint4(1546212312, 1648393417, 1857132231, 1909506562);
            uint b2 = (1718582899);
            bool4 r2 = bool4(true, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint4 a3 = uint4(1294006045, 1303736668, 845460171, 979430272);
            uint b3 = (952084157);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4_operator_less_scalar_wide()
        {
            uint a0 = (186400299);
            uint4 b0 = uint4(1881344229, 813834467, 1254886626, 1353590345);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1412343685);
            uint4 b1 = uint4(1555571443, 1540508298, 1735458634, 135888070);
            bool4 r1 = bool4(true, true, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (1643818742);
            uint4 b2 = uint4(248291654, 1739560105, 728539891, 480507742);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (1696553040);
            uint4 b3 = uint4(540223931, 1840493353, 146833656, 798115946);
            bool4 r3 = bool4(false, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4_operator_greater_wide_wide()
        {
            uint4 a0 = uint4(2087717754, 1725569452, 1298066182, 1693943616);
            uint4 b0 = uint4(85148514, 293632137, 1151128249, 409440398);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint4 a1 = uint4(1319019629, 70674491, 1042499725, 1002821508);
            uint4 b1 = uint4(1115020183, 1508500597, 1834583302, 1755218534);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint4 a2 = uint4(1021857133, 1744374599, 821751047, 467646903);
            uint4 b2 = uint4(1788761753, 1128238489, 834223713, 1578743290);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint4 a3 = uint4(2029731638, 1377214212, 1207816926, 474621063);
            uint4 b3 = uint4(1647150256, 1756397855, 1131080201, 1208965204);
            bool4 r3 = bool4(true, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4_operator_greater_wide_scalar()
        {
            uint4 a0 = uint4(1208626274, 239697208, 1979453345, 1253474001);
            uint b0 = (1715176566);
            bool4 r0 = bool4(false, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint4 a1 = uint4(1590192876, 1673945595, 1662650098, 222749855);
            uint b1 = (1487911635);
            bool4 r1 = bool4(true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint4 a2 = uint4(1433540517, 1773305960, 1850273578, 206147145);
            uint b2 = (566635217);
            bool4 r2 = bool4(true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint4 a3 = uint4(325913453, 1905567362, 2053577491, 570397194);
            uint b3 = (333381537);
            bool4 r3 = bool4(false, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4_operator_greater_scalar_wide()
        {
            uint a0 = (480938827);
            uint4 b0 = uint4(1824731899, 921496110, 586859044, 946430596);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1231356727);
            uint4 b1 = uint4(1390167458, 1785807092, 28949024, 2037899283);
            bool4 r1 = bool4(false, false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (595656760);
            uint4 b2 = uint4(1778095771, 1233500439, 1696302238, 1445965340);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (484020151);
            uint4 b3 = uint4(1586962841, 1361740714, 265628948, 2003122957);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4_operator_less_equal_wide_wide()
        {
            uint4 a0 = uint4(154092149, 1515170149, 1083970332, 785807178);
            uint4 b0 = uint4(77984380, 1712054191, 1566203809, 254834519);
            bool4 r0 = bool4(false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint4 a1 = uint4(1401094881, 310537627, 868328962, 1990816725);
            uint4 b1 = uint4(450519938, 389457083, 1298669505, 207343167);
            bool4 r1 = bool4(false, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint4 a2 = uint4(2035349541, 457043352, 1123282035, 1001842946);
            uint4 b2 = uint4(1214449047, 2059561026, 896534357, 1897470050);
            bool4 r2 = bool4(false, true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint4 a3 = uint4(1387761992, 195272789, 659549000, 888761458);
            uint4 b3 = uint4(521075677, 1848221945, 374708019, 1573731118);
            bool4 r3 = bool4(false, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4_operator_less_equal_wide_scalar()
        {
            uint4 a0 = uint4(1479531977, 1427983411, 415250630, 1245345407);
            uint b0 = (2004563877);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint4 a1 = uint4(1112546666, 1579912858, 101048307, 1070894375);
            uint b1 = (1072990632);
            bool4 r1 = bool4(false, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint4 a2 = uint4(509818792, 85452501, 518127023, 1246249980);
            uint b2 = (1910488590);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint4 a3 = uint4(1097326500, 1968139888, 1191853379, 662096238);
            uint b3 = (1964410699);
            bool4 r3 = bool4(true, false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4_operator_less_equal_scalar_wide()
        {
            uint a0 = (1899193992);
            uint4 b0 = uint4(915011820, 980913757, 1337699683, 1476321359);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1102143668);
            uint4 b1 = uint4(660493983, 184664508, 381579707, 1954892821);
            bool4 r1 = bool4(false, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (1295090571);
            uint4 b2 = uint4(1440368586, 1696003686, 88708652, 1332251857);
            bool4 r2 = bool4(true, true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (1310713644);
            uint4 b3 = uint4(2112132784, 48951945, 1888568027, 39340955);
            bool4 r3 = bool4(true, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4_operator_greater_equal_wide_wide()
        {
            uint4 a0 = uint4(8538378, 2131749726, 265427108, 523609761);
            uint4 b0 = uint4(903145828, 1697992986, 1432491982, 169789504);
            bool4 r0 = bool4(false, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint4 a1 = uint4(994991818, 839709564, 101288202, 1886280970);
            uint4 b1 = uint4(1059357300, 1744255222, 1606584463, 1905414425);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint4 a2 = uint4(2032074826, 631221455, 1456286159, 961342752);
            uint4 b2 = uint4(1448794969, 136181998, 1678754836, 2069656857);
            bool4 r2 = bool4(true, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint4 a3 = uint4(424526026, 788481984, 1662488497, 870326690);
            uint4 b3 = uint4(398982689, 243317404, 740939613, 1894753119);
            bool4 r3 = bool4(true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4_operator_greater_equal_wide_scalar()
        {
            uint4 a0 = uint4(2049236663, 182691143, 634973382, 1197012109);
            uint b0 = (1061998015);
            bool4 r0 = bool4(true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint4 a1 = uint4(439837565, 1108037359, 351147187, 1898505669);
            uint b1 = (1367606469);
            bool4 r1 = bool4(false, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint4 a2 = uint4(411667685, 4652390, 996159180, 2111455181);
            uint b2 = (1998610091);
            bool4 r2 = bool4(false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint4 a3 = uint4(727766399, 814085575, 1525995206, 1293933760);
            uint b3 = (96217144);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1859811087);
            uint4 b0 = uint4(1070365918, 1783869452, 830091760, 377157428);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (327199016);
            uint4 b1 = uint4(90384229, 1154649706, 376758501, 1079802834);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (2054742898);
            uint4 b2 = uint4(1328349472, 434061447, 951207723, 598695892);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (975131651);
            uint4 b3 = uint4(1714007943, 177416473, 1267232721, 31082860);
            bool4 r3 = bool4(false, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4_operator_add_wide_wide()
        {
            uint4 a0 = uint4(2135171378, 21433296, 1954723494, 683604307);
            uint4 b0 = uint4(1013431952, 366718162, 359290756, 1393163294);
            uint4 r0 = uint4(3148603330, 388151458, 2314014250, 2076767601);
            TestUtils.AreEqual(a0 + b0, r0);

            uint4 a1 = uint4(1054212315, 1762680995, 1963655852, 1257853062);
            uint4 b1 = uint4(1962236872, 1263270041, 1862666629, 1077447887);
            uint4 r1 = uint4(3016449187, 3025951036, 3826322481, 2335300949);
            TestUtils.AreEqual(a1 + b1, r1);

            uint4 a2 = uint4(2043493600, 976898058, 1915056423, 121374462);
            uint4 b2 = uint4(821693806, 487316539, 350922520, 1583012528);
            uint4 r2 = uint4(2865187406, 1464214597, 2265978943, 1704386990);
            TestUtils.AreEqual(a2 + b2, r2);

            uint4 a3 = uint4(1218855698, 700538222, 1702057277, 1788251699);
            uint4 b3 = uint4(1951595076, 1024851344, 874302782, 1383969588);
            uint4 r3 = uint4(3170450774, 1725389566, 2576360059, 3172221287);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4_operator_add_wide_scalar()
        {
            uint4 a0 = uint4(665815972, 1783729250, 1591678394, 1284528538);
            uint b0 = (1334043849);
            uint4 r0 = uint4(1999859821, 3117773099, 2925722243, 2618572387);
            TestUtils.AreEqual(a0 + b0, r0);

            uint4 a1 = uint4(977850224, 1138577680, 1200356017, 565982008);
            uint b1 = (71069732);
            uint4 r1 = uint4(1048919956, 1209647412, 1271425749, 637051740);
            TestUtils.AreEqual(a1 + b1, r1);

            uint4 a2 = uint4(1246759684, 57252642, 678921480, 625943813);
            uint b2 = (1088001167);
            uint4 r2 = uint4(2334760851, 1145253809, 1766922647, 1713944980);
            TestUtils.AreEqual(a2 + b2, r2);

            uint4 a3 = uint4(512157429, 1490096953, 1467033531, 182608093);
            uint b3 = (1470648741);
            uint4 r3 = uint4(1982806170, 2960745694, 2937682272, 1653256834);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4_operator_add_scalar_wide()
        {
            uint a0 = (359966320);
            uint4 b0 = uint4(2146146202, 767103309, 851002415, 311531406);
            uint4 r0 = uint4(2506112522, 1127069629, 1210968735, 671497726);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (1491262941);
            uint4 b1 = uint4(1016891373, 1954228994, 1671335850, 727870747);
            uint4 r1 = uint4(2508154314, 3445491935, 3162598791, 2219133688);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (551151834);
            uint4 b2 = uint4(1390261152, 1699060326, 115021619, 1964440175);
            uint4 r2 = uint4(1941412986, 2250212160, 666173453, 2515592009);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (440700758);
            uint4 b3 = uint4(1556692550, 185414255, 933106731, 1217866784);
            uint4 r3 = uint4(1997393308, 626115013, 1373807489, 1658567542);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4_operator_sub_wide_wide()
        {
            uint4 a0 = uint4(1410318491, 1097280168, 1827039044, 28881338);
            uint4 b0 = uint4(1315897366, 799052018, 1580289673, 1094686261);
            uint4 r0 = uint4(94421125, 298228150, 246749371, 3229162373);
            TestUtils.AreEqual(a0 - b0, r0);

            uint4 a1 = uint4(328720965, 875487868, 212936325, 231977215);
            uint4 b1 = uint4(1954325726, 1197734816, 229886366, 915679176);
            uint4 r1 = uint4(2669362535, 3972720348, 4278017255, 3611265335);
            TestUtils.AreEqual(a1 - b1, r1);

            uint4 a2 = uint4(1740021315, 2011295463, 48079003, 591379285);
            uint4 b2 = uint4(1746884850, 918743925, 1007797419, 257421324);
            uint4 r2 = uint4(4288103761, 1092551538, 3335248880, 333957961);
            TestUtils.AreEqual(a2 - b2, r2);

            uint4 a3 = uint4(1125909359, 1842588095, 848561896, 614448464);
            uint4 b3 = uint4(287249342, 1617287463, 1653916102, 123586847);
            uint4 r3 = uint4(838660017, 225300632, 3489613090, 490861617);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4_operator_sub_wide_scalar()
        {
            uint4 a0 = uint4(1508669340, 1594795463, 266707545, 643102647);
            uint b0 = (998008471);
            uint4 r0 = uint4(510660869, 596786992, 3563666370, 3940061472);
            TestUtils.AreEqual(a0 - b0, r0);

            uint4 a1 = uint4(287705008, 1113286221, 979450511, 2082174113);
            uint b1 = (1475644328);
            uint4 r1 = uint4(3107027976, 3932609189, 3798773479, 606529785);
            TestUtils.AreEqual(a1 - b1, r1);

            uint4 a2 = uint4(1108005498, 999244508, 1806482044, 1994553647);
            uint b2 = (304369206);
            uint4 r2 = uint4(803636292, 694875302, 1502112838, 1690184441);
            TestUtils.AreEqual(a2 - b2, r2);

            uint4 a3 = uint4(2101812429, 266654115, 1470212363, 1190349300);
            uint b3 = (1482736902);
            uint4 r3 = uint4(619075527, 3078884509, 4282442757, 4002579694);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4_operator_sub_scalar_wide()
        {
            uint a0 = (893369501);
            uint4 b0 = uint4(2051906184, 1699714311, 442603706, 1735141684);
            uint4 r0 = uint4(3136430613, 3488622486, 450765795, 3453195113);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (274533585);
            uint4 b1 = uint4(811580259, 1196354320, 1524097023, 533621527);
            uint4 r1 = uint4(3757920622, 3373146561, 3045403858, 4035879354);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (2080845793);
            uint4 b2 = uint4(143958837, 1620668660, 1135989346, 1367044745);
            uint4 r2 = uint4(1936886956, 460177133, 944856447, 713801048);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (554088609);
            uint4 b3 = uint4(552670373, 1265516124, 1254902543, 1857695581);
            uint4 r3 = uint4(1418236, 3583539781, 3594153362, 2991360324);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4_operator_mul_wide_wide()
        {
            uint4 a0 = uint4(61417577, 219585476, 1362520891, 1511084277);
            uint4 b0 = uint4(578042444, 1620527213, 200516468, 309339115);
            uint4 r0 = uint4(2868103468, 1326150260, 3304073148, 2972110823);
            TestUtils.AreEqual(a0 * b0, r0);

            uint4 a1 = uint4(1481211272, 58211871, 1459591173, 567624644);
            uint4 b1 = uint4(542853019, 299467282, 1479641221, 1428338601);
            uint4 r1 = uint4(1973926232, 88546350, 3431047833, 3712145508);
            TestUtils.AreEqual(a1 * b1, r1);

            uint4 a2 = uint4(1169935583, 1835691886, 385626539, 85934842);
            uint4 b2 = uint4(1497302909, 1596889147, 427413842, 265122693);
            uint4 r2 = uint4(556671459, 1098186330, 1848083398, 4236646882);
            TestUtils.AreEqual(a2 * b2, r2);

            uint4 a3 = uint4(522856538, 278370196, 289217012, 2083410174);
            uint4 b3 = uint4(689376654, 1120457204, 516903000, 873091659);
            uint4 r3 = uint4(2005201900, 651971856, 2573806560, 4184807018);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4_operator_mul_wide_scalar()
        {
            uint4 a0 = uint4(871746615, 492532311, 570557670, 2142306629);
            uint b0 = (442064533);
            uint4 r0 = uint4(338365955, 1081376419, 2565819870, 3279557417);
            TestUtils.AreEqual(a0 * b0, r0);

            uint4 a1 = uint4(1610315153, 118471734, 257439514, 364291059);
            uint b1 = (1526163563);
            uint4 r1 = uint4(2932083611, 3961756306, 2388105182, 3815128721);
            TestUtils.AreEqual(a1 * b1, r1);

            uint4 a2 = uint4(1186560810, 1357601203, 638897141, 268562104);
            uint b2 = (1584938026);
            uint4 r2 = uint4(989596900, 898280286, 2953765426, 2323925552);
            TestUtils.AreEqual(a2 * b2, r2);

            uint4 a3 = uint4(1007838321, 1619806399, 1444659979, 1127580168);
            uint b3 = (1163240135);
            uint4 r3 = uint4(610309591, 1971350137, 984126349, 1871258680);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4_operator_mul_scalar_wide()
        {
            uint a0 = (1152242766);
            uint4 b0 = uint4(1276636134, 2105929407, 499007702, 124002565);
            uint4 r0 = uint4(2165463060, 999811634, 1179056436, 3493540742);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1956335172);
            uint4 b1 = uint4(1288034953, 832676555, 337389733, 99268757);
            uint4 r1 = uint4(303483492, 4218558444, 1271140820, 1556966804);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (2005055247);
            uint4 b2 = uint4(2011389505, 1348110859, 399689191, 2007606374);
            uint4 r2 = uint4(2729770191, 2761028517, 4045388169, 759270394);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (2076691289);
            uint4 b3 = uint4(1825721194, 769885235, 153314735, 1066325369);
            uint4 r3 = uint4(609175002, 2727503547, 1593384663, 1878927889);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4_operator_div_wide_wide()
        {
            uint4 a0 = uint4(333171510, 858154903, 1181365836, 671357749);
            uint4 b0 = uint4(698897823, 440199998, 655557473, 1658534285);
            uint4 r0 = uint4(0, 1, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint4 a1 = uint4(1090606752, 803759420, 788404166, 296807814);
            uint4 b1 = uint4(2127220100, 315653188, 1814290360, 992173243);
            uint4 r1 = uint4(0, 2, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint4 a2 = uint4(575260195, 166625280, 1493729000, 1831739736);
            uint4 b2 = uint4(914851653, 664340325, 224323977, 246981573);
            uint4 r2 = uint4(0, 0, 6, 7);
            TestUtils.AreEqual(a2 / b2, r2);

            uint4 a3 = uint4(200852358, 129983172, 500176108, 472051781);
            uint4 b3 = uint4(285573983, 819471609, 2012476015, 1783179572);
            uint4 r3 = uint4(0, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4_operator_div_wide_scalar()
        {
            uint4 a0 = uint4(1433072926, 1073958635, 1195142312, 536596719);
            uint b0 = (1434025872);
            uint4 r0 = uint4(0, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint4 a1 = uint4(1274375693, 806462546, 906504670, 1380905136);
            uint b1 = (464756346);
            uint4 r1 = uint4(2, 1, 1, 2);
            TestUtils.AreEqual(a1 / b1, r1);

            uint4 a2 = uint4(25493909, 123300377, 643754735, 2084019932);
            uint b2 = (1196815948);
            uint4 r2 = uint4(0, 0, 0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint4 a3 = uint4(2047825037, 741331531, 466443901, 2110004616);
            uint b3 = (458304263);
            uint4 r3 = uint4(4, 1, 1, 4);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4_operator_div_scalar_wide()
        {
            uint a0 = (519165704);
            uint4 b0 = uint4(1295178177, 775214121, 467772046, 1156881598);
            uint4 r0 = uint4(0, 0, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (310396565);
            uint4 b1 = uint4(759759959, 243837702, 1616314235, 1053470225);
            uint4 r1 = uint4(0, 1, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1320630160);
            uint4 b2 = uint4(378773841, 4223608, 1971105754, 2054406020);
            uint4 r2 = uint4(3, 312, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (219939614);
            uint4 b3 = uint4(1603672651, 2006134295, 888535397, 1493077923);
            uint4 r3 = uint4(0, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4_operator_mod_wide_wide()
        {
            uint4 a0 = uint4(258342924, 1454754891, 723352342, 1981431473);
            uint4 b0 = uint4(1990080167, 1197348066, 651970512, 1659454050);
            uint4 r0 = uint4(258342924, 257406825, 71381830, 321977423);
            TestUtils.AreEqual(a0 % b0, r0);

            uint4 a1 = uint4(531756042, 716993627, 1667903349, 1331097004);
            uint4 b1 = uint4(241005212, 1866255454, 1440101415, 595220963);
            uint4 r1 = uint4(49745618, 716993627, 227801934, 140655078);
            TestUtils.AreEqual(a1 % b1, r1);

            uint4 a2 = uint4(1776856101, 17598216, 1474345080, 1681376293);
            uint4 b2 = uint4(408818410, 198222574, 549504274, 239973807);
            uint4 r2 = uint4(141582461, 17598216, 375336532, 1559644);
            TestUtils.AreEqual(a2 % b2, r2);

            uint4 a3 = uint4(813624265, 1617478722, 498370451, 780075943);
            uint4 b3 = uint4(321398087, 658171840, 1511495237, 1048325585);
            uint4 r3 = uint4(170828091, 301135042, 498370451, 780075943);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4_operator_mod_wide_scalar()
        {
            uint4 a0 = uint4(560988938, 629524514, 767711194, 434281967);
            uint b0 = (1156862367);
            uint4 r0 = uint4(560988938, 629524514, 767711194, 434281967);
            TestUtils.AreEqual(a0 % b0, r0);

            uint4 a1 = uint4(1399805893, 1663690927, 598661916, 1776636144);
            uint b1 = (792916846);
            uint4 r1 = uint4(606889047, 77857235, 598661916, 190802452);
            TestUtils.AreEqual(a1 % b1, r1);

            uint4 a2 = uint4(1287035793, 475209785, 327476870, 1617696916);
            uint b2 = (1743722161);
            uint4 r2 = uint4(1287035793, 475209785, 327476870, 1617696916);
            TestUtils.AreEqual(a2 % b2, r2);

            uint4 a3 = uint4(379853074, 858399046, 712734431, 1506629323);
            uint b3 = (477430114);
            uint4 r3 = uint4(379853074, 380968932, 235304317, 74338981);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4_operator_mod_scalar_wide()
        {
            uint a0 = (933347930);
            uint4 b0 = uint4(549923387, 243114953, 1884274390, 1428033594);
            uint4 r0 = uint4(383424543, 204003071, 933347930, 933347930);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (655531454);
            uint4 b1 = uint4(1622674954, 1107563514, 1614111094, 914801920);
            uint4 r1 = uint4(655531454, 655531454, 655531454, 655531454);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (1432263179);
            uint4 b2 = uint4(564431096, 1967013901, 1709750152, 1080102613);
            uint4 r2 = uint4(303400987, 1432263179, 1432263179, 352160566);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (13120773);
            uint4 b3 = uint4(2042535998, 1505698002, 1640058084, 974167554);
            uint4 r3 = uint4(13120773, 13120773, 13120773, 13120773);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4_operator_plus()
        {
            uint4 a0 = uint4(195392567, 222719748, 1002351013, 1570765263);
            uint4 r0 = uint4(195392567, 222719748, 1002351013, 1570765263);
            TestUtils.AreEqual(+a0, r0);

            uint4 a1 = uint4(109389333, 1689763402, 291471785, 264115671);
            uint4 r1 = uint4(109389333, 1689763402, 291471785, 264115671);
            TestUtils.AreEqual(+a1, r1);

            uint4 a2 = uint4(1084131995, 2131702223, 715660442, 1995564647);
            uint4 r2 = uint4(1084131995, 2131702223, 715660442, 1995564647);
            TestUtils.AreEqual(+a2, r2);

            uint4 a3 = uint4(69731564, 1957501908, 531426536, 2012985092);
            uint4 r3 = uint4(69731564, 1957501908, 531426536, 2012985092);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void uint4_operator_neg()
        {
            uint4 a0 = uint4(1385088677, 94114564, 1350664872, 1458616659);
            uint4 r0 = uint4(2909878619, 4200852732, 2944302424, 2836350637);
            TestUtils.AreEqual(-a0, r0);

            uint4 a1 = uint4(2067164853, 958484951, 270553961, 446497525);
            uint4 r1 = uint4(2227802443, 3336482345, 4024413335, 3848469771);
            TestUtils.AreEqual(-a1, r1);

            uint4 a2 = uint4(270503114, 1427605822, 2051940607, 1434247484);
            uint4 r2 = uint4(4024464182, 2867361474, 2243026689, 2860719812);
            TestUtils.AreEqual(-a2, r2);

            uint4 a3 = uint4(485368391, 1742096480, 990033169, 1368056141);
            uint4 r3 = uint4(3809598905, 2552870816, 3304934127, 2926911155);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void uint4_operator_prefix_inc()
        {
            uint4 a0 = uint4(780471723, 954741756, 272723451, 2142862245);
            uint4 r0 = uint4(780471724, 954741757, 272723452, 2142862246);
            TestUtils.AreEqual(++a0, r0);

            uint4 a1 = uint4(606294309, 250124151, 444189162, 1833356994);
            uint4 r1 = uint4(606294310, 250124152, 444189163, 1833356995);
            TestUtils.AreEqual(++a1, r1);

            uint4 a2 = uint4(1915989169, 129540735, 1584496757, 1170613526);
            uint4 r2 = uint4(1915989170, 129540736, 1584496758, 1170613527);
            TestUtils.AreEqual(++a2, r2);

            uint4 a3 = uint4(986715680, 1397451003, 483952900, 1494652811);
            uint4 r3 = uint4(986715681, 1397451004, 483952901, 1494652812);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void uint4_operator_postfix_inc()
        {
            uint4 a0 = uint4(241865086, 2145821641, 1596166022, 803592338);
            uint4 r0 = uint4(241865086, 2145821641, 1596166022, 803592338);
            TestUtils.AreEqual(a0++, r0);

            uint4 a1 = uint4(529551271, 903047443, 1213663244, 1425753247);
            uint4 r1 = uint4(529551271, 903047443, 1213663244, 1425753247);
            TestUtils.AreEqual(a1++, r1);

            uint4 a2 = uint4(1384002775, 1159795446, 1343289659, 1227160199);
            uint4 r2 = uint4(1384002775, 1159795446, 1343289659, 1227160199);
            TestUtils.AreEqual(a2++, r2);

            uint4 a3 = uint4(947635082, 451018043, 1634297552, 2009552507);
            uint4 r3 = uint4(947635082, 451018043, 1634297552, 2009552507);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void uint4_operator_prefix_dec()
        {
            uint4 a0 = uint4(1331961415, 1612382200, 1401591249, 2042075388);
            uint4 r0 = uint4(1331961414, 1612382199, 1401591248, 2042075387);
            TestUtils.AreEqual(--a0, r0);

            uint4 a1 = uint4(1757136546, 1467742422, 578341664, 1336115745);
            uint4 r1 = uint4(1757136545, 1467742421, 578341663, 1336115744);
            TestUtils.AreEqual(--a1, r1);

            uint4 a2 = uint4(2059077641, 1862369220, 312317355, 1027543764);
            uint4 r2 = uint4(2059077640, 1862369219, 312317354, 1027543763);
            TestUtils.AreEqual(--a2, r2);

            uint4 a3 = uint4(1595492535, 1426620468, 674685792, 1423852012);
            uint4 r3 = uint4(1595492534, 1426620467, 674685791, 1423852011);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void uint4_operator_postfix_dec()
        {
            uint4 a0 = uint4(1870005937, 1708534798, 704493460, 462940703);
            uint4 r0 = uint4(1870005937, 1708534798, 704493460, 462940703);
            TestUtils.AreEqual(a0--, r0);

            uint4 a1 = uint4(2060593573, 940247280, 1818778351, 1015253889);
            uint4 r1 = uint4(2060593573, 940247280, 1818778351, 1015253889);
            TestUtils.AreEqual(a1--, r1);

            uint4 a2 = uint4(862428933, 2080259851, 653673271, 140452688);
            uint4 r2 = uint4(862428933, 2080259851, 653673271, 140452688);
            TestUtils.AreEqual(a2--, r2);

            uint4 a3 = uint4(1928164223, 1174531383, 634036198, 993137684);
            uint4 r3 = uint4(1928164223, 1174531383, 634036198, 993137684);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void uint4_operator_bitwise_and_wide_wide()
        {
            uint4 a0 = uint4(1055241304, 859321394, 1088358961, 2090949513);
            uint4 b0 = uint4(749698416, 748105424, 1842764797, 9990577);
            uint4 r0 = uint4(749024336, 537928720, 1087769137, 8409473);
            TestUtils.AreEqual(a0 & b0, r0);

            uint4 a1 = uint4(300561740, 651904515, 1331035868, 2012752753);
            uint4 b1 = uint4(1989102105, 1666634755, 58116798, 868036607);
            uint4 r1 = uint4(277479432, 575816707, 55888540, 867707761);
            TestUtils.AreEqual(a1 & b1, r1);

            uint4 a2 = uint4(1298126656, 53199569, 1752363533, 1303061302);
            uint4 b2 = uint4(1420638875, 1308767169, 564040763, 478617502);
            uint4 r2 = uint4(1141707264, 33686209, 538087433, 209912598);
            TestUtils.AreEqual(a2 & b2, r2);

            uint4 a3 = uint4(1929998247, 1504941434, 470682792, 713577376);
            uint4 b3 = uint4(806150474, 674015378, 1505309955, 36064977);
            uint4 r3 = uint4(805855490, 136347666, 403178496, 33571456);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_and_wide_scalar()
        {
            uint4 a0 = uint4(1513158868, 284695609, 734595037, 1566510707);
            uint b0 = (1173647397);
            uint4 r0 = uint4(1076916228, 15732769, 29360133, 1163132961);
            TestUtils.AreEqual(a0 & b0, r0);

            uint4 a1 = uint4(1601252476, 314333543, 430856908, 753481263);
            uint b1 = (84213838);
            uint4 r1 = uint4(83951692, 262214, 17039436, 67174414);
            TestUtils.AreEqual(a1 & b1, r1);

            uint4 a2 = uint4(327392481, 2143619546, 1873208293, 126982769);
            uint b2 = (1619794917);
            uint4 r2 = uint4(8394977, 1619265984, 1619264485, 8395361);
            TestUtils.AreEqual(a2 & b2, r2);

            uint4 a3 = uint4(651482651, 1689107088, 1368301071, 366962092);
            uint b3 = (1383096952);
            uint4 r3 = uint4(38814232, 1075847696, 1342177800, 273702952);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (477163326);
            uint4 b0 = uint4(110453385, 703240362, 2075630560, 1884904031);
            uint4 r0 = uint4(68182536, 140544042, 405834528, 273697310);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (1734899436);
            uint4 b1 = uint4(947945203, 1664399051, 458879298, 158491426);
            uint4 r1 = uint4(536901344, 1663055560, 55078976, 23093792);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (79772356);
            uint4 b2 = uint4(2054527944, 202228212, 359225061, 639811396);
            uint4 r2 = uint4(4266688, 67174596, 71373508, 67123780);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (1821945318);
            uint4 b3 = uint4(1821303024, 2030124055, 1985961756, 579780373);
            uint4 r3 = uint4(1820893408, 1744841734, 1679297796, 545828100);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_or_wide_wide()
        {
            uint4 a0 = uint4(1920951869, 1750772852, 1420019191, 732977093);
            uint4 b0 = uint4(214585254, 275414367, 858759675, 190211455);
            uint4 r0 = uint4(2130669503, 2021326207, 2008016383, 737572863);
            TestUtils.AreEqual(a0 | b0, r0);

            uint4 a1 = uint4(1169579447, 229437930, 1966721348, 2039812323);
            uint4 b1 = uint4(1218691723, 2129565457, 1862809466, 495728846);
            uint4 r1 = uint4(1303895999, 2146367483, 2134507390, 2107455727);
            TestUtils.AreEqual(a1 | b1, r1);

            uint4 a2 = uint4(113550869, 1912038362, 1569990624, 1490718227);
            uint4 b2 = uint4(868064152, 1756913766, 933656055, 247722084);
            uint4 r2 = uint4(939376541, 2046780414, 2142664695, 1591475831);
            TestUtils.AreEqual(a2 | b2, r2);

            uint4 a3 = uint4(1686257697, 2137727522, 1569900650, 856504729);
            uint4 b3 = uint4(1884195075, 1804207631, 1913174711, 1815920856);
            uint4 r3 = uint4(1959708963, 2146117167, 2140863231, 2134768089);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_or_wide_scalar()
        {
            uint4 a0 = uint4(1295304853, 1307252624, 350194630, 1128063578);
            uint b0 = (1305527136);
            uint4 r0 = uint4(1307888629, 1308350448, 1574947814, 1341973370);
            TestUtils.AreEqual(a0 | b0, r0);

            uint4 a1 = uint4(1774824542, 1988423804, 999162350, 2110327307);
            uint b1 = (2085245467);
            uint4 r1 = uint4(2110520927, 2127491711, 2144228351, 2110478875);
            TestUtils.AreEqual(a1 | b1, r1);

            uint4 a2 = uint4(1050875188, 1317039676, 228656898, 41280811);
            uint b2 = (341855232);
            uint4 r2 = uint4(1055087924, 1591766588, 501305090, 376827179);
            TestUtils.AreEqual(a2 | b2, r2);

            uint4 a3 = uint4(1536908787, 1739461580, 2040936581, 1350320187);
            uint b3 = (606786773);
            uint4 r3 = uint4(2143018487, 1739511773, 2108619989, 1954469119);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1768627592);
            uint4 b0 = uint4(1849658052, 1759912154, 729979455, 975926310);
            uint4 r0 = uint4(1870634956, 1777286618, 1810603967, 2070642094);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1987690876);
            uint4 b1 = uint4(1809506714, 1160695341, 408963395, 314072711);
            uint4 r1 = uint4(2147213822, 2004864893, 2121910655, 1996087295);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (1560007537);
            uint4 b2 = uint4(1709003416, 977086639, 1448375596, 1689568808);
            uint4 r2 = uint4(2113917945, 2130705407, 1593833341, 2097141625);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (595543345);
            uint4 b3 = uint4(559778387, 621080913, 438994183, 1742637145);
            uint4 r3 = uint4(595578739, 662697329, 998229303, 1744817529);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_xor_wide_wide()
        {
            uint4 a0 = uint4(1843655608, 362425681, 640805534, 1342040268);
            uint4 b0 = uint4(1422803441, 1234691140, 119589253, 1101464929);
            uint4 r0 = uint4(959296073, 1544407317, 554771227, 240840109);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint4 a1 = uint4(945678755, 980321850, 390165019, 1682422658);
            uint4 b1 = uint4(121896337, 1880109018, 1000210266, 1718938232);
            uint4 r1 = uint4(1058935858, 1249815008, 752651585, 36917754);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint4 a2 = uint4(303897251, 230477768, 1103646442, 1503102919);
            uint4 b2 = uint4(464406940, 884337881, 34199854, 1430659227);
            uint4 r2 = uint4(162747199, 956900113, 1136760772, 215066460);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint4 a3 = uint4(26631152, 1016475570, 1862440929, 379588576);
            uint4 b3 = uint4(126415540, 1069919967, 1810763253, 2082802224);
            uint4 r3 = uint4(102672708, 55804269, 82614804, 1787102672);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_xor_wide_scalar()
        {
            uint4 a0 = uint4(169345668, 176087064, 2084362901, 1663924004);
            uint b0 = (354464228);
            uint4 r0 = uint4(523809632, 526275068, 1763470193, 1980614336);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint4 a1 = uint4(193851255, 905336222, 863800783, 365003873);
            uint b1 = (517476661);
            uint4 r1 = uint4(357957186, 724452523, 765762810, 186226004);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint4 a2 = uint4(835837496, 1464576786, 625604047, 1700827127);
            uint b2 = (954341348);
            uint4 r2 = uint4(154388956, 1873394934, 497803819, 1568839699);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint4 a3 = uint4(2003392824, 1077374714, 1043379893, 1991576049);
            uint b3 = (1481813598);
            uint4 r3 = uint4(792459110, 409321636, 1717704939, 786933679);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1361775641);
            uint4 b0 = uint4(1452773578, 459050892, 1986218254, 1689037698);
            uint4 r0 = uint4(129801427, 1249346453, 659047703, 898082715);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (999278344);
            uint4 b1 = uint4(1229114508, 1087843538, 733699740, 106187872);
            uint4 r1 = uint4(1926040452, 2069425114, 271882644, 1037798248);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1533632738);
            uint4 b2 = uint4(1107817672, 492506236, 597602329, 1439603382);
            uint4 r2 = uint4(426677290, 1177709726, 2029506811, 245889620);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (1001169118);
            uint4 b3 = uint4(1231718216, 1693179077, 1050897427, 1796435561);
            uint4 r3 = uint4(1925588886, 1598520347, 84921549, 1354747575);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4_operator_left_shift()
        {
            uint4 a0 = uint4(1129100049, 829482269, 1571297368, 443753193);
            int b0 = (218351941);
            uint4 r0 = uint4(1771463200, 773628832, 3036875520, 1315200288);
            TestUtils.AreEqual(a0 << b0, r0);

            uint4 a1 = uint4(1872142968, 892627436, 980302862, 62369727);
            int b1 = (249554593);
            uint4 r1 = uint4(3744285936, 1785254872, 1960605724, 124739454);
            TestUtils.AreEqual(a1 << b1, r1);

            uint4 a2 = uint4(849916599, 108441902, 1959056531, 1779118882);
            int b2 = (1271350845);
            uint4 r2 = uint4(3758096384, 3221225472, 1610612736, 1073741824);
            TestUtils.AreEqual(a2 << b2, r2);

            uint4 a3 = uint4(1451674188, 1149883636, 1380536034, 186532735);
            int b3 = (2082026915);
            uint4 r3 = uint4(3023458912, 609134496, 2454353680, 1492261880);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void uint4_operator_right_shift()
        {
            uint4 a0 = uint4(809126085, 908563670, 763568837, 1986717290);
            int b0 = (994800051);
            uint4 r0 = uint4(1543, 1732, 1456, 3789);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint4 a1 = uint4(1174507510, 1242726074, 390811632, 1521420393);
            int b1 = (646821842);
            uint4 r1 = uint4(4480, 4740, 1490, 5803);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint4 a2 = uint4(1923166649, 400863878, 667378673, 1611921244);
            int b2 = (102096936);
            uint4 r2 = uint4(7512369, 1565874, 2606947, 6296567);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint4 a3 = uint4(307750782, 2014389412, 1673938174, 1075916177);
            int b3 = (479442287);
            uint4 r3 = uint4(9391, 61474, 51084, 32834);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_not()
        {
            uint4 a0 = uint4(111796841, 603562399, 745091931, 853183268);
            uint4 r0 = uint4(4183170454, 3691404896, 3549875364, 3441784027);
            TestUtils.AreEqual(~a0, r0);

            uint4 a1 = uint4(1110916612, 1891338755, 1506860135, 771210628);
            uint4 r1 = uint4(3184050683, 2403628540, 2788107160, 3523756667);
            TestUtils.AreEqual(~a1, r1);

            uint4 a2 = uint4(787710759, 96456785, 916013379, 203444882);
            uint4 r2 = uint4(3507256536, 4198510510, 3378953916, 4091522413);
            TestUtils.AreEqual(~a2, r2);

            uint4 a3 = uint4(1172294211, 683852713, 375158799, 881353367);
            uint4 r3 = uint4(3122673084, 3611114582, 3919808496, 3413613928);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}