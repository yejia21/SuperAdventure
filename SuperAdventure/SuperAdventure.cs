using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
	public partial class SuperAdventure : Form
	{
		private Player _player = new Player(200,10,0,10,100);
		private Location _location = new Location(1, "Home", "My home");
		//public  Item _item1 = new Item(1, "Card", "Gold card");

		//private Quest _quest = new Quest(110, "attach", "attack a monster", 101, 200, _item1);
		
		public SuperAdventure()
		{


			//_quest = new Quest(110, "attach", "attack a monster", 101, 200, _item1);
			InitializeComponent();

			lblHitPoints.Text = _player.CurrentHitPoints.ToString();
			lblExperience.Text = _player.ExperiencePoints.ToString();
			//lblExperience.Text = _quest.RewardItem.NamePlural;
			lblGold.Text = _player.Gold.ToString();
			lblLevel.Text = _player.Level.ToString();

		}

		private void SuperAdventure_Load(object sender, EventArgs e)
		{

		}


	

		
	}
}
