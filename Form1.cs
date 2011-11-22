    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;

    using System.Collections;
    using System.Resources;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    


    namespace uBet
    {      


        public partial class Form1 : Form
        {

            BindingList<Gambler> users;
            BindingList<BetType> bettypes = new BindingList<BetType>();

            public Form1()
            {

                
                this.bookie = new Bookie();
                InitializeComponent();

                teamlistBox_Populate(1);
                userlistBox_Populate();

                BetReadycontestlistBox_Populate();
                contestlistBox_Populate();
                ActivecontestlistBox_Populate();

                betTypelistBox_Populate();
                admincstteamlistbox_Populate();
                
                this.betbutton.Click += new System.EventHandler(this.betbutton_Click);
              

               toteGridView.DataSource = bookie.buildTote(2,1);
               gamblerGridView.DataSource = bookie.buildGamblerTote( 1);
               AccountGridView.DataSource = bookie.showAccounts();
            }


            private void userlistBox_Populate() {
                users = bookie.showUsers();
                userlistBox.DataSource = users;
                listBox3.DataSource = users;
            }

            private void betbutton_Click(object sender, System.EventArgs e)
            {
                System.Collections.Hashtable newbet = new System.Collections.Hashtable();

                Gambler gambler = (Gambler)this.userlistBox.SelectedItem;
                newbet.Add("uid", gambler.uid);

                BetType bt = (BetType)this.bettypelistBox.SelectedItem;
                newbet.Add("betypetid", bt.BetId);
                
                Contest c = (Contest)this.contestlistBox.SelectedItem;
                newbet.Add("contestid", c.ContestId);

                 
                newbet.Add("amt", (double)this.betAmtUpDown.Value );
                Team team = (Team)this.teamlistBox.SelectedItem;
                newbet.Add("tm", team.TeamId);

                int x = this.bookie.InsertBet(newbet);

                //string cwd = System.IO.Directory.GetCurrentDirectory();
                //string cwd =Application.ExecutablePath;
                System.Windows.Forms.MessageBox.Show(this.userlistBox.Text, this.userlistBox.Text,
                           System.Windows.Forms.MessageBoxButtons.OK,
                           System.Windows.Forms.MessageBoxIcon.Information);

                //this.bookie.showBettor(6);
            }


            private void userbutton_Click(object sender, System.EventArgs e)
            {
                string email = this.textBox2.Text;
                double balance = double.Parse(this.textBox3.Text);
                System.Windows.Forms.MessageBox.Show(email, "User",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Information);

                this.bookie.InsertUser(email, balance);

                userlistBox_Populate();
                AccountGridView.DataSource = bookie.showAccounts();
            }

            private void teamlistBox_Populate(int contest)
            {                
                System.Collections.Generic.List<Team> x = this.bookie.showTeams(contest);
                teamlistBox.DataSource = x;               
            }

            private void winnerteamlistBox_Populate(int contest)
            {
                System.Collections.Generic.List<Team> x = this.bookie.showTeams(contest);
                admWinnerTeamListBox.DataSource = x;
                
            }

            private void admincstteamlistbox_Populate()
            {
                
                System.Collections.Generic.List<Team> x = this.bookie.showTeams();
                this.admincstteamlistbox.DataSource = x;
          
            }
            


            private void betTypelistBox_Populate()
            {
                bettypes.Clear();
                bettypes.Add(new BetType("Win", 1));
                bettypes.Add(new BetType("Place", 2));
                bettypes.Add(new BetType("Show", 3));

                bettypelistBox.DataSource = bettypes;
                listBox2.DataSource = bettypes;
                 
            }


            

            private void BetReadycontestlistBox_Populate()
            {

                System.Collections.Generic.List<Contest> x = this.bookie.showBetReadyContests();
                contestlistBox.DataSource = x;
                               
            }

            private void ActivecontestlistBox_Populate()
            {
           
                System.Collections.Generic.List<Contest> x = this.bookie.showActiveContests();
     
                reccontestlistBox.DataSource = x;
                listBox1.DataSource = x; 
                admincontestlistBox.DataSource = x;
            }


            private void contestlistBox_Populate()
            {

                System.Collections.Generic.List<Contest> x = this.bookie.showContests();
                //contestlistBox.DataSource = x;
                
               // admincontestlistBox.DataSource = x;
                
            } 

             

            private void admincontestbutton_Click(object sender, EventArgs e)
            {
                string contest = this.admincontesttextBox.Text;

                System.Windows.Forms.MessageBox.Show(contest, "Contest",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Information);


                
                int[] teamids = new int[this.admincstteamlistbox.SelectedItems.Count];
                int i = 0;
                foreach( Team t in this.admincstteamlistbox.SelectedItems ){                  
                  teamids[i] = t.TeamId;
                  i++;
                }
                                
                 
                int cid  = this.bookie.InsertContest(contest,teamids);
                
                System.Windows.Forms.MessageBox.Show(cid.ToString(), "New CID",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Information);

                this.contestlistBox_Populate();
                this.ActivecontestlistBox_Populate();
                
            }


            private void contestlistBox_SelectedValueChanged(object sender, EventArgs e) {
                Contest c = (Contest)this.contestlistBox.SelectedItem;
                
                this.teamlistBox_Populate( c.ContestId );
            }

            private void totegridbtn_Click(object sender, EventArgs e)
            {

                Contest c = (Contest)this.listBox1.SelectedItem;
                BetType bt = (BetType)this.listBox2.SelectedItem;     
                
                toteGridView.DataSource = bookie.buildTote(c.ContestId, bt.BetId); 
            }

            private void userBetsbtn_Click(object sender, EventArgs e)
            {
                Gambler g = (Gambler)this.listBox3.SelectedItem;
                gamblerGridView.DataSource = bookie.buildGamblerTote(g.uid); 
            }

            private void adminteambtn_Click(object sender, EventArgs e)
            {
                string team = this.adminteamtextBox.Text;
                this.bookie.InsertTeam( team );

                admincstteamlistbox_Populate();
            }

            private void reconShowbtn_Click(object sender, EventArgs e)
            {
                Contest c = (Contest)this.reccontestlistBox.SelectedItem;

                reconcileGridView.DataSource = bookie.showContestBettors(c.ContestId, this.payOffcheckBox.Checked);

                string winner = bookie.GetWinner(c.ContestId);
                if (winner == null)
                {
                    reconReconbtn.Enabled = false;
                }
                else {
                    reconReconbtn.Enabled = true;
                }
            }

            private void admincontestlistBox_SelectedValueChanged(object sender, EventArgs e)
            {
                Contest c = (Contest)this.admincontestlistBox.SelectedItem;

                this.winnerteamlistBox_Populate(c.ContestId);

                 this.WinnerLabel.Text = "Winner: " + bookie.GetWinner(c.ContestId);
            }

            private void winnerBtn_Click(object sender, EventArgs e)
            {
                Contest c = (Contest)this.admincontestlistBox.SelectedItem;
                Team t = (Team)admWinnerTeamListBox.SelectedItem;
                this.bookie.SetWinner(c.ContestId,t.TeamId);

                this.WinnerLabel.Text = "Winner: " + t.TeamName;

                BetReadycontestlistBox_Populate();
            }


            private void reconReconbtn_Click(object sender, EventArgs e)
            {
                Contest c = (Contest)this.reccontestlistBox.SelectedItem;
                this.bookie.ReconcileBets(c.ContestId);
                
                reconReconbtn.Enabled = false;

                ActivecontestlistBox_Populate();
            }

           

           


        }
    }
