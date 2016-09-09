using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UCS.PacketProcessing
{
	internal class BattleReplayMessage : Message
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class BattleReplayMessageIntel
        {
			public static readonly BattleReplayMessage.BattleReplayMessageIntel ins = new BattleReplayMessage.BattleReplayMessageIntel();

			public static Func<int, bool> func;

			internal bool StringToByteArray(int x)
			{
				return x % 2 == 0;
			}
		}

		private static string hex = "B5D908000005D85D260000789CAD594D8FDC4410FD2F3E8F5057557FEE1924103920C10DAD568EC790D14E6656B34E4814ADC43F405C40E2C69D0BB71CF835280271E22FD06D777BD6F6B6BB47CD1EB233B3AEE757AFAA5E9727EFAAE775D7EDDBEAEA5DB56D9B5B565D7D6D5F5557A899FBA14DD5D9371CB590466DAAA6BA02B6A9F6D595D95487F63BF77E539D9A83BD0AE06133C4CA3E16C758426EFA58ADFB5838C78810A3FA1836C64844F4F763F320390D3A93545AD28CA40FC11032E405FD5546CE91D9F432F6249899E40967CEC4A558701E543A33E153F2A34A06B48148B4BBC728D8F5A62F15CC4AE553A2594A6A4216A5BF1D316D947C9C1EC56AA21E8788F51E984A834F85F6916A29C71081E708EDF96998AB41CB7A0DA578949D6D8627EF27A61516CBFBCD2370DAD63C19A15C89EAD775579F981BACBA698EAF0EDD671F7FF462D7EB7CFE607F744908836831DA3777CFDAD7ADCFD5BEFBE2B83B74F716502865C30EF54B3BA8D5AB43B36F1B0B65EFBDAF0F37FEE3BF7EFAF99FDFFFF8FBB71F3FBCFFDEFE6BFF5A9FDA435D5D091ECAF8BCDE7EDBBAF9E9A7C6F8F8DDF6C6F1C2F35BC74A6950F410F280651E729E0792614AA9491E38B27EB6EBDA3F7FF9F5DFF73FCC78BFF8FC93FBBBE3C9E69962DC8F639CB12B54D51D5F9D1CB0ABC337F5FEBEB5A5393675B73B1E5CF17B14BDB8910D6C0FDBAF76CDADAD8F740DD7BCDCF6F3D5747D791B97BF2BBBB1AA7568AF02FB62B7FD741062B77DF65880DDF64DCFEECEFE32C2D1BE7B6B3F10F6E5836BA61928B9D9ED415D170CA01440C7EEE841D5004A2328600494031F4039F10453BE00553150E999729D62EA41F9199422A052D300AA1825406101CA23A08A0B0FEA2C79357DAFA91E410962A0060750ED1A7B95A91840E5B9FA31A6C6784D810124A88A6CAA164C05585209B234878DD60A98940156CB045B5F2D71D640C76001022C904CB095032C66B005810156A52AC6176C63A36561CD089BB20139878DB3450A22A04889E0B585F424008E0D46909ADA8569D93F4760295821F0A4172ECD20E630368DD0B75CA5FA562C60A36C050611044F8920E7B026866A44A858BF4CE59C07E721C35823200B649125C9AAB9D140CC1210999F06EC77EB55B6B4381362B38B38B2459E696067588C55CC82E9002B759E8199F49021315F3224FCFF86CCD63288402A25825C942CCA96A33F1B91F3D4E1888B92C561B51F326B712AC1962FB48DCDAE7DCA0B2288A4D3E4FB220A1A6145E6DAA133D80A1D1A4CB25483E5EF5D28390FB032B5792D86377AE6A052DE6E519994DD2E86376E354A074FD02C7542E6AF09A87968302D532E0E0B6DA35366A4DFEAD0E8D45AE7AD46A5B52546BE1388895427C8EC4E20A6C25ECF4CCA13165613354682F17101F072AB89694BE30A46E9156CF1C410D716C2794E903CCF31FB9981900558C49483B185D544B5B595F2B084994B4DC66313116080A5D494E55B0DD1A82DE5EE4A1953461CC33870AE13222CAD26AA2D0F4F4FF6ACCCB41A955132318E83488E0344FCF6DA3EFFBFEEFA07FEEEED5DDB5FE8BF64E809DE4CBEA7E976CDEDBDBD1850DAC0BBFA54BF746FF1DAD1BB245E9A74BC1CE3C754C678A51EC7B34BEF8F50C69FF8249E2E8DE78CA7E357F227C18BF8735065FC8528BABF543A5DBF95FC856145FCD5B4FE17DF5F9BB2FA1B8645F50786650504A6271D041703C074049E06584B0158590FDB15C094A580D32EBCDC85489602182CD380732CD340B00C11579D9865A4B006604094B5B2621966B0C2C02E54190CD6008051919D20322805C830A4750053080065471A5A0A85003CE350595B0A9054D134224A284CC16454618D01990C535D63C075D9C98A5C94AD56285014591A0A99C1604D034965DB292A285B6F5009281371C6E0625B473D3D5C2F1F26650A45D4846522EAC24E2406197EB0B6A5332CEB03F71FED8529A80C475A03B06B5A190310191BCA9A06A0CB164DB29D54D4CA16A0B00A24CAD67D2215F544CA02E0A26CDD274E652B8E7D62CE70A455063AE35C586560A21AE48928A6DF5A5887745F9F9C0EDB2FDB766B598064426A29F8C37F9B565FC9";

		public BattleReplayMessage(Client client) : base(client)
		{
			base.SetMessageType(24114);
		}

		public override void Encode()
		{
			base.Encrypt(BattleReplayMessage.StringToByteArray(BattleReplayMessage.hex));
		}

		public static byte[] StringToByteArray(string hex)
		{
			IEnumerable<int> arg_3D_0 = Enumerable.Range(0, hex.Length);
            Func<int, bool> arg_3D_1 = null;
			if (arg_3D_1 == null)
			{
                arg_3D_1 = BattleReplayMessageIntel.ins.StringToByteArray;

            }
			return (from x in arg_3D_0.Where(arg_3D_1)
			select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray<byte>();
		}
	}
}