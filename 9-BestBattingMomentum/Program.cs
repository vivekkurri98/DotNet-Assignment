using _9_BestBattingMomentum;
Console.WriteLine("9) If Batting Momentum = Runs Scored * Strike Rate, write a program that will return the batsman\r\nwith the best batting momentum from the below object.\r\n[\r\n{\"Batsman\": \"Virat Kholi\", \"RunsScored\": 50, \"StrikeRate\": 78.30},\r\n{\"Batsman\": \"M.S.Dhoni\", \"RunsScored\": 61, \"StrikeRate\": 58.90},\r\n{\"Batsman\": \"Rohit Sharma\", \"RunsScored\": 13, \"StrikeRate\": 124.0}\r\n]");
CalculateBattingMomentum calculateBattingMomentum = new CalculateBattingMomentum();
calculateBattingMomentum.GetBatsManWithBestMomentum();


