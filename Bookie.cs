
// C:\Program Files\SQLite.NET\bin
/*
 *  csc Bookie.cs /r:System.Data.SQLite.DLL /o /nologo
 */

using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;




public class BetType
{
    public string BetName;
    public int BetId;

    public BetType()
    {
    }

    public BetType(string Bet_Name, int Bet_Id)
    {
        this.BetId = Bet_Id;
        this.BetName = Bet_Name;
    }

    public override string ToString()
    {
        return (BetName);
    }
}

public class Team
{
    public string TeamName;
    public int TeamId;

    public Team()
    {
    }

    public Team(string Team_Name, int Team_Id)
    {
        this.TeamId = Team_Id;
        this.TeamName = Team_Name;
    }

    public override string ToString()
    {
        return (TeamName);
    }
}


public class Contest : INotifyPropertyChanged
{
    private int _ContestId;
    private string _Desc;
    public event PropertyChangedEventHandler PropertyChanged;

    public Contest(string desc, int contest_id)
    {
        this._ContestId = contest_id;
        this._Desc = desc;
    }

    public string Desc
    {
        get { return _Desc; }
        set
        {
            _Desc = value;
            this.NotifyPropertyChanged("Description");
        }
    }

    public int ContestId
    {
        get { return _ContestId; }
        set
        {
            _ContestId = value;
            this.NotifyPropertyChanged("ContestID");
        }
    }

    public override string ToString()
    {
        return (Desc);
    }

    private void NotifyPropertyChanged(string name)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

}



public class Gambler : INotifyPropertyChanged
{
    public int uid;
    public int contest;
    public double amt;
    public ArrayList prob;
    public double poff;
    public string team;
    public int bettype;
    public string email;
    public event PropertyChangedEventHandler PropertyChanged;
    private string[] bet = new string[]{"","WIN","PLACE","SHOW"};

    private string contestName;
    private string TeamName;

    public Gambler( string email,int uid)
    {
        this.uid = uid;
        this.email = email;
    }

    public Gambler(int uid
                    , ArrayList prob
                    , double poff
                    , string team_id
                    , int contest
                    , int bettype
                    , double amount
                    , string email    )
    {
        this.uid = uid;
        this.amt = amount;
        this.contest = contest;
        this.prob = prob;
        this.poff = poff;
        this.bettype = bettype;
        this.team = team_id;
        this.email = email;
    }

    public string Email {
        get { return email; }
        set
        {
            email = value;
            this.NotifyPropertyChanged("Email");
        }
    }

    public int UID
    {
        get { return uid; }
        set
        {
            uid = value;
            this.NotifyPropertyChanged("UID");
        }
    }

    public double Amount
    {
        get { return amt; }
        set
        {
            amt = value;
            this.NotifyPropertyChanged("Amount");
        }
    }

    public string Contest
    {
        get { return contestName; }
        set
        {
            contestName = value;
            this.NotifyPropertyChanged("Contest");
        }
    }

    public string Team
    {
        get { return TeamName; }
        set
        {
            TeamName = value;
            this.NotifyPropertyChanged("Team");
        }
    }

    public double Payoff
    {
        get { return poff; }
        set
        {
            poff = value;
            this.NotifyPropertyChanged("PayOff");
        }
    }

    public string Bet
    {
        get { return bet[bettype]; }
        set
        {
            //bettype = value;
            this.NotifyPropertyChanged("BetType");
        }
    }

    private void NotifyPropertyChanged(string name)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

    public override string ToString()
    {
        return (email);
    }

}





public class Account : INotifyPropertyChanged
{
    private int uid;    
    private double balance;
    private  string email;
    public event PropertyChangedEventHandler PropertyChanged;
    
     

    public Account(string email, int uid, double balance)
    {
        this.uid = uid;
        this.email = email;
        this.balance = balance;
    }

    

    public string Email
    {
        get { return email; }
        set
        {
            email = value;
            this.NotifyPropertyChanged("Email");
        }
    }

    public int UID
    {
        get { return uid; }
        set
        {
            uid = value;
            this.NotifyPropertyChanged("UID");
        }
    }

    public double Balance
    {
        get { return balance; }
        set
        {
            balance = value;
            this.NotifyPropertyChanged("Amount");
        }
    }
     

    private void NotifyPropertyChanged(string name)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

    public override string ToString()
    {
        return (email);
    }

}






public class Bookie
{
    DbConnection cnn;
    double netamt = 1.0;
    double take = 0.0;
    public Hashtable bettypeLookup = new Hashtable();
    public Hashtable teamLookup = new Hashtable();
    BindingList<Tote> tote = new BindingList<Tote>();
    BindingList<Gambler> gamblerTote = new BindingList<Gambler>();

    public Bookie()
    {
        this.netamt = 1 - take / 100;
                    string cwd =System.IO.Directory.GetCurrentDirectory();
                    string dsn = "Data Source=" + cwd + "\\bookie.db3";
                    //"Data Source=c:\\code\\csharp\\bookie.db3"
        this.cnn = new SQLiteConnection(dsn);
        this.cnn.Open();

        populateTeamLookup();
        populateBetLookup();

    }

    public Bookie(double tk)
    {
        this.netamt = 1 - tk / 100;
        this.cnn = new SQLiteConnection("Data Source=c:\\code\\csharp\\bookie.db3");
        this.cnn.Open();

        populateTeamLookup();
        populateBetLookup();

    }

    ~Bookie()
    {
        try
        {
            this.cnn.Close();
        }
        catch
        {
        }
    }


    //will show the bettor
    public BindingList<Gambler> buildGamblerTote(int uid)
    {
        gamblerTote.Clear();
        List<Gambler> c = showActiveBettor(uid);

        foreach (Gambler g in c)
        {
            g.Contest = showContest(g.contest);
            g.Team = showTeam( Convert.ToInt32(g.team) );
            
            gamblerTote.Add(
                    g
                    );
        }

        return gamblerTote;
    }




    public BindingList<Tote> buildTote(int contest, int btype )
    {

        Dictionary<string, ArrayList> p = setProbs(contest, btype);
        tote.Clear();

        foreach (string k in p.Keys)
        {            
            tote.Add(
                    new Tote(
                        showTeam( Convert.ToInt32(k))
                        , p[k]
                        )
                    );            
        }


            return tote;
    }


    public int UpdateUserBalance(double amount, int uid)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "Update Users set balance = balance - ? where user_id = ?";

        DbParameter amt = cmd.CreateParameter();
        cmd.Parameters.Add(amt);

        DbParameter userID = cmd.CreateParameter();                     
        cmd.Parameters.Add(userID);              

        userID.Value = uid;        
        amt.Value = amount;

        cmd.ExecuteNonQuery();

        return (1);
    }


     

    public void  ReconcileBets( int contest_id){
        BindingList<Gambler> winners = showContestBettors(contest_id, true);

        foreach( Gambler g in winners ){
            UpdateUserBalance(g.Payoff * -1, g.UID);
        }

        DeactivateContest(contest_id);
    }

    public int InsertBet(Hashtable h)
    {

        UpdateUserBalance( (double)h["amt"],(int)h["uid"] );

        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "INSERT INTO bets (user_id,bet_type_id,amount,contest_id,team_id) VALUES(?,?,?,?,?)";

        DbParameter userID = cmd.CreateParameter();
        DbParameter bettypeID = cmd.CreateParameter();
        DbParameter amountX = cmd.CreateParameter();
        DbParameter contestID = cmd.CreateParameter();
        DbParameter team = cmd.CreateParameter();

        cmd.Parameters.Add(userID);
        cmd.Parameters.Add(bettypeID);
        cmd.Parameters.Add(amountX);
        cmd.Parameters.Add(contestID);
        cmd.Parameters.Add(team);

        userID.Value = (int)h["uid"];
        bettypeID.Value = (int)h["betypetid"];
        amountX.Value = (double)h["amt"];
        contestID.Value = (int)h["contestid"];
        team.Value = (int)h["tm"];

        cmd.ExecuteNonQuery();

        return (1);
    }

    public int InsertTeam(string teamname)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "INSERT INTO teams (team_name) VALUES(?)";

        DbParameter team = cmd.CreateParameter();
          
        cmd.Parameters.Add(team);
        team.Value = teamname;
         

        cmd.ExecuteNonQuery();

        return (1);
    }


    public int InsertUser(string email, double balance)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "INSERT INTO users (email,balance) VALUES(?,?)";

        DbParameter emailaddr = cmd.CreateParameter();
        DbParameter bal = cmd.CreateParameter();

        cmd.Parameters.Add(emailaddr);
        emailaddr.Value = email;

        cmd.Parameters.Add(bal);
        bal.Value = balance;

        cmd.ExecuteNonQuery();

        return (1);
    }

    public int SetWinner(int contestID,int teamID)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "Update contest set result = ?   where contest_id = ?";


        DbParameter tid = cmd.CreateParameter();
        cmd.Parameters.Add(tid);
        tid.Value = teamID;

        DbParameter cid = cmd.CreateParameter();        
        cmd.Parameters.Add(cid);
        cid.Value = contestID;

        
        cmd.ExecuteNonQuery();

        return (1);
    }

    public string GetWinner(int contest)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select team_name from teams,contest where contest_id = ? and contest.result = teams.team_id";

        DbParameter pcontestID = cmd.CreateParameter();
        cmd.Parameters.Add(pcontestID);

        pcontestID.Value = contest;


        string desc = null;

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                desc = reader[0].ToString();
            }
        }

        return (desc);
    }



    public int DeactivateContest(int contestID)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "Update contest set active = 0 where contest_id = ?";

        DbParameter id = cmd.CreateParameter();
        

        cmd.Parameters.Add(id);
        id.Value = contestID;               

        cmd.ExecuteNonQuery();

        return (1);
    }

    public int InsertContest(string desc, int[] TeamIDs)
    {
        DbTransaction dbTrans = this.cnn.BeginTransaction();

        DbCommand cmd = this.cnn.CreateCommand();

        cmd.Transaction = dbTrans;

        cmd.CommandText = "INSERT INTO contest (desc) VALUES(?)";
        cmd.CommandText += ";SELECT last_insert_rowid() AS [ID]";

        DbParameter pdesc = cmd.CreateParameter();

        cmd.Parameters.Add(pdesc);
        pdesc.Value = desc;

        int contestID = Convert.ToInt32(cmd.ExecuteScalar());
        

        //------------------------------------
        //------- now insert the associated teams
               
        cmd.CommandText = "INSERT INTO contest_team_rel (team_id,contest_id) VALUES(?,?)";
        
        for (int j=0; j<TeamIDs.Length ;j++ )
        {        
            cmd.Parameters.Clear();

            DbParameter ptid = cmd.CreateParameter();
            DbParameter pcid = cmd.CreateParameter();
            
            cmd.Parameters.Add(ptid);
            ptid.Value = TeamIDs[j];

            cmd.Parameters.Add(pcid);
            pcid.Value = contestID;

            cmd.ExecuteNonQuery();
        }

        dbTrans.Commit();

        return (contestID);
    }



    void DisplayTote(int contest)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select bet_type_id,sum(amount) amt from bets, contest where contest_id = ? and bets.contest_id = contest.contest_id and contest.active =1 group by bet_type_id";

        DbParameter pcontestID = cmd.CreateParameter();
        cmd.Parameters.Add(pcontestID);

        pcontestID.Value = contest;

        Console.WriteLine("\n");

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Dictionary<string, ArrayList> p = setProbs(contest, Convert.ToInt32(reader[0]));
                foreach (string k in p.Keys)
                {
                    Console.WriteLine(String.Format("Contest ={0} k={1} type ={2} prob={3} Pool={4}"
                                                    , contest, k, reader[0], p[k][0], reader[1]));
                }
            }
        }
    }


    public List<Team> showTeams(int contest)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select t.team_name, t.team_id " +
                          "from teams t,contest_team_rel ct " +
                          "where t.team_id = ct.team_id " +
                          "and ct.contest_id = ? ";

        DbParameter pcontestID = cmd.CreateParameter();
        cmd.Parameters.Add(pcontestID);

        pcontestID.Value = contest;
        List<Team> teams = new List<Team>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {

            while (reader.Read())
            {
                teams.Add(new Team((string)reader[0], Convert.ToInt32(reader[1])));
            }
        }

        return (teams);
    }


    public List<Team> showTeams()
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select t.team_name, t.team_id " +
                          "from teams t " ;

      
        List<Team> teams = new List<Team>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                teams.Add(new Team((string)reader[0], Convert.ToInt32(reader[1])));
            }
        }

        return (teams);
    }


    public List<int> xshowTeams(int contest)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select t.team_id " +
                          "from teams t,contest_team_rel ct " +
                          "where t.team_id = ct.team_id " +
                          "and ct.contest_id = ? ";

        DbParameter pcontestID = cmd.CreateParameter();
        cmd.Parameters.Add(pcontestID);

        pcontestID.Value = contest;
        List<int> teams = new List<int>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {

            while (reader.Read())
            {
                teams.Add(Convert.ToInt32(reader[0]) );
            }
        }

        return (teams);
    }


    public string showContest(int contestID)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select c.desc " +
                          "from contest c " +
                          "where c.contest_id = ? ";

        DbParameter pcontestID = cmd.CreateParameter();
        cmd.Parameters.Add(pcontestID);

        pcontestID.Value = contestID;
        string desc = null;

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                desc = reader[0].ToString();
            }
        }

        return (desc);
    }


    public string showTeam(int team_id)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select t.team_name " +
                          "from teams t " +
                          "where t.team_id = ? ";

        DbParameter pteamID = cmd.CreateParameter();
        cmd.Parameters.Add(pteamID);

        pteamID.Value = team_id;
        string team_name=null;

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                team_name = reader[0].ToString();
            }
        }

        return (team_name);
    }


    private void populateTeamLookup()
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select t.team_name, t.team_id " +
                          "from teams t ";

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                teamLookup.Add(Convert.ToString(reader[1]), reader[0]);
            }
        }
    }

    private void populateBetLookup()
    {
        bettypeLookup.Add(1, "Win");
        bettypeLookup.Add(2, "Place");
        bettypeLookup.Add(3, "Show");
    }

    public List<Contest> showContests()
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select desc ,contest_id  from contest  ";

        List<Contest> contests = new List<Contest>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                contests.Add(new Contest((string)reader[0], Convert.ToInt32(reader[1])));
            }
        }
        return (contests);
    }

    //can still bet on these
    public List<Contest> showBetReadyContests()
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select desc ,contest_id  from contest  where result IS NULL  ";

        List<Contest> contests = new List<Contest>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                contests.Add(new Contest((string)reader[0], Convert.ToInt32(reader[1])));
            }
        }
        return (contests);
    }

    public List<Contest> showActiveContests()
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select desc ,contest_id  from contest  where active =1  ";

        List<Contest> contests = new List<Contest>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                contests.Add(new Contest((string)reader[0], Convert.ToInt32(reader[1])));
            }
        }
        return (contests);
    }



    public BindingList<Gambler> showUsers()
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select distinct email,user_id  from users";

        BindingList<Gambler> users = new BindingList<Gambler>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {

            while (reader.Read())
            {
                users.Add(new Gambler((string)reader[0], Convert.ToInt32(reader[1])));
            }
        }

        return (users);
    }


    public List<int> zshowUsers()
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "select distinct user_id  from users";

        List<int> users = new List<int>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {

            while (reader.Read())
            {
                users.Add(Convert.ToInt32(reader[0]));
            }
        }

        return (users);
    }


    /*
     * key   is team
     * value is [ prob,ret,odds,totamt ]
     */
    public Dictionary<string, ArrayList> setProbs(int contest, int btype)
    {
        Hashtable totals = new Hashtable();
        Dictionary<string, ArrayList> probHash = new Dictionary<string, ArrayList>();

        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "SELECT sum(amount) * " + this.netamt +
                          " amt,bet_type_id,contest_id FROM bets where contest_id =? and bet_type_id =? group by contest_id,bet_type_id ";

        DbParameter pContestid = cmd.CreateParameter();
        DbParameter pBetID = cmd.CreateParameter();
        cmd.Parameters.Add(pContestid);
        cmd.Parameters.Add(pBetID);
        pContestid.Value = contest;
        pBetID.Value = btype;

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                // Console.WriteLine(String.Format("Total = {0}, BetType = {1}", reader[0],reader[1]));
                totals.Add(reader[1], reader[0]);
            }
        }


        cmd.CommandText = "SELECT sum(amount) * " + this.netamt +
                          " amt,team_id,bet_type_id,contest_id FROM bets where contest_id =? and bet_type_id =? group by contest_id, bet_type_id,team_id";
        DbDataReader teamreader = cmd.ExecuteReader();
        while (teamreader.Read())
        {
            double prob = (double)teamreader[0] / (double)totals[teamreader[2]];
            double ret = betReturn(prob);
            string odds = fractionalOdds(prob);


            ArrayList attr = new ArrayList();
            attr.Add(prob);
            attr.Add(ret);
            attr.Add(odds);
            attr.Add((double)teamreader[0]);

            probHash.Add(teamreader[1].ToString(), attr);
            //  Console.WriteLine(String.Format("Total = {0}, Team = {1}, BetType = {2}, Prob = {3}, Odds = {4}, Ret = {5}"
            //                                  ,teamreader[0],teamreader[1],teamreader[2],prob,odds,ret));
        }
        teamreader.Dispose();

        return (probHash);
    }


    public List<Gambler> showActiveBettor(int uid)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "SELECT (amount * " + this.netamt + ") amt ,bet_type_id,bets.contest_id,team_id,email FROM bets,users,contest where bets.user_id = ? and bets.user_id = users.user_id and bets.contest_id = contest.contest_id and contest.active <> 0 order by bet_type_id";

        DbParameter pUID = cmd.CreateParameter();
        cmd.Parameters.Add(pUID);
        pUID.Value = uid;

        List<Gambler> gambler = new List<Gambler>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Dictionary<string, ArrayList> p = setProbs(Convert.ToInt32(reader[2]), Convert.ToInt32(reader[1]));
                double poff = payoff(Convert.ToDouble(reader[0]), (double)p[reader[3].ToString()][1], Convert.ToInt32(reader[1]));

                Gambler g = new Gambler(uid
                                         , p[reader[3].ToString()] //only need the probs for this team & bettype
                                         , poff
                                         , reader[3].ToString()
                                         , Convert.ToInt32(reader[2])
                                         , Convert.ToInt32(reader[1])
                                         , Convert.ToDouble(reader[0])
                                         , reader[4].ToString()
                                       );
                gambler.Add(g);
            }
        }

        return (gambler);
    }


    public List<Gambler> showBettor(int uid)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "SELECT (amount * " + this.netamt + ") amt ,bet_type_id,contest_id,team_id,email FROM bets,users where bets.user_id = ? and bets.user_id = users.user_id order by bet_type_id";
        
        DbParameter pUID = cmd.CreateParameter();
        cmd.Parameters.Add(pUID);
        pUID.Value = uid;

        List<Gambler> gambler = new List<Gambler>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Dictionary<string, ArrayList> p = setProbs(Convert.ToInt32(reader[2]), Convert.ToInt32(reader[1]));
                double poff = payoff(Convert.ToDouble(reader[0]), (double)p[reader[3].ToString()][1], Convert.ToInt32(reader[1]));

                Gambler g = new Gambler(uid
                                         , p[reader[3].ToString()] //only need the probs for this team & bettype
                                         , poff
                                         , reader[3].ToString()
                                         , Convert.ToInt32(reader[2])
                                         , Convert.ToInt32(reader[1])
                                         , Convert.ToDouble(reader[0])
                                         ,reader[4].ToString() 
                                       );
                gambler.Add(g);
            }
        }

        return (gambler);
    }


    public BindingList<Gambler> showContestBettors(int contestID, bool payoffOnly)
    {
        DbCommand cmd = this.cnn.CreateCommand();

        if (payoffOnly)
        {
            cmd.CommandText = "SELECT (amount * " + this.netamt + ") amt ,bet_type_id,bets.contest_id,bets.team_id,bets.user_id,email FROM bets,users,contest where bets.contest_id = ?  and users.user_id = bets.user_id and contest.result = bets.team_id   and bets.contest_id = contest.contest_id order by bet_type_id, users.user_id";
        }
        else {
            cmd.CommandText = "SELECT (amount * " + this.netamt + ") amt ,bet_type_id,contest_id,team_id,bets.user_id,email FROM bets,users where contest_id = ?   and users.user_id = bets.user_id order by bet_type_id, users.user_id";
        }


        DbParameter cID = cmd.CreateParameter();
        cmd.Parameters.Add(cID);
        cID.Value = contestID;

        BindingList<Gambler> gambler = new BindingList<Gambler>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Dictionary<string, ArrayList> p = setProbs(Convert.ToInt32(reader[2]), Convert.ToInt32(reader[1]));
                double poff = payoff(Convert.ToDouble(reader[0]), (double)p[reader[3].ToString()][1], Convert.ToInt32(reader[1]));

                Gambler g = new Gambler(Convert.ToInt32(reader[4])
                                         , p[reader[3].ToString()] //only need the probs for this team & bettype
                                         , poff
                                         , reader[3].ToString()
                                         , Convert.ToInt32(reader[2])
                                         , Convert.ToInt32(reader[1])
                                         , Convert.ToDouble(reader[0])
                                         , reader[5].ToString()
                                       );

                g.Contest = showContest(g.contest);
                g.Team = showTeam(Convert.ToInt32(g.team));
                
                gambler.Add(g);
            }
        }

        return (gambler);
    }



    void xshowBettor(int uid)
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "SELECT (amount * " + this.netamt + ") amt ,bet_type_id,contest_id,team_id FROM bets where user_id = ?";

        Console.Write("UID= " + uid + "\n");
        DbParameter pUID = cmd.CreateParameter();
        cmd.Parameters.Add(pUID);
        pUID.Value = uid;

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Dictionary<string, ArrayList> p = setProbs(Convert.ToInt32(reader[2]), Convert.ToInt32(reader[1]));
                double poff = payoff(Convert.ToDouble(reader[0]), (double)p[reader[3].ToString()][1], Convert.ToInt32(reader[1]));
                Console.WriteLine(String.Format("AMT = {0}, BetType = {1}, Contest = {2}, TEAM = {3}, PROB = {4}, PAYOFF={5}, ret={6}"
                                                , reader[0], reader[1], reader[2], reader[3], p[reader[3].ToString()][0], poff, p[reader[3].ToString()][1]
                                               ));
            }
        }
    }


    public BindingList<Account> showAccounts()
    {
        DbCommand cmd = this.cnn.CreateCommand();
        cmd.CommandText = "SELECT balance ,email,user_id  FROM users ";

        BindingList<Account> accounts = new BindingList<Account>();

        using (DbDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                accounts.Add(
                    new Account(reader[1].ToString(),Convert.ToInt32(reader[2]),Convert.ToDouble(reader[0]))
                    );
            }
        }

        return accounts;
    }
 

    static double betReturn(double prob)
    {
        double b = prob * 100;
        double x = Math.Abs((100) - b);
        double ret = x / b;

        return (ret);
    }

    static double payoff(double amount, double ret, int bet_type)
    {
        double p = ((amount * ret) + amount) / bet_type;  // dived by 1,2,3 for win,place show

        return (p);
    }


    static string fractionalOdds(double prob)
    {
        double probc = prob * 100;
        double x = (100) - probc;

        int iprobc = (int)probc;
        int ix = (int)x;
        int k = gcd(ix, iprobc);

        ix /= k;
        iprobc /= k;

        string odds = ix + "/" + iprobc;
        return (odds);
    }

    public static int gcd(int x, int y)
    {
        if (y == 0)
        {
            return (x);
        }
        return (gcd(y, x % y));
    }

   
}





public class Tote : INotifyPropertyChanged
{
    
     
    private  ArrayList mytote;
    private string team;
    public event PropertyChangedEventHandler PropertyChanged;

    public Tote( string k ,ArrayList  inmytote)
    {
         
         /*
     * key   is team
     * value is [ prob,ret,odds,totamt ]
     */
        team = k;
        mytote = inmytote; // bookie.setProbs(contest, btype);
    //Collection c = mytote.Keys;  
   

    }

    public string Team
    {
        get { return team; }
        set
        {
            // _make = value;
            this.NotifyPropertyChanged("Team");
        }
    }

    public double Prob
    {
        get { return (double)mytote [0]; }
        set
        {
           // _make = value;
            this.NotifyPropertyChanged("Prob");
        }
    }

    public double DecimalOdds
    {
        get { return 1/ (double)mytote[0]; }
        set
        {
            // _make = value;
            this.NotifyPropertyChanged("DecimalOdds");
        }
    }
    /*
    public double Ret
    {
        get { return (double)mytote [1]; }
        set
        {
            //_model = value;
            this.NotifyPropertyChanged("Ret");
        }
    }
    */
    public string Odds
    {
        get { return (string)mytote [2]; }
        set
        {
           // _year = value;
            this.NotifyPropertyChanged("Odds");
        }
    }

    public double Pool
    {
        get { return (double)mytote[3]; }
        set
        {
            // _year = value;
            this.NotifyPropertyChanged("Pool");
        }
    }



    private void NotifyPropertyChanged(string name)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(name));
    }
}