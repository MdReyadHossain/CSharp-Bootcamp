using Practice;

DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
string dateTime = dateTimeOffset.ToUnixTimeMilliseconds().ToString();

/*
uid = 1720448946 => 9DD52BOE7BC0741BCO429

1 - 1720448946 x 448946 = 772388672510916
2 - 2BE7BC0741BC4 (last digit = 4)
		
							 YES : 448946 + 6 = 448952 x 9 = 4040568
3 - isPrime (last digit 4) <
							 NO  : 448946 + 3 = 448949 x 9 = 4040541

4 - 4040541 = last 2 digit, Q = 41 and rest of digit, P = 40405
5 - P = 9DD5, Q = 29
6 - 2BE7BC0741BC4 -> P 2B O E7BC0741BC O 4 Q
	=> 9DD52BOE7BC0741BCO429 
*/
Console.WriteLine(SecretKey.Encrypt(dateTime));



Console.WriteLine();


/*
1478816O3EFBA585A5624O15F => 1720599931649

clientUid = 1478816O3EFBA585A5624O15F
1 - 14788 163EFBA585A56241 5F
2 - 14788 -> 83848; 5F -> 95
3 - 8384895 / 9 = 931655
							YES : 931655 - 6 = 931649
4 - isPrime(last digit 1) <
							NO  : 931655 - 3 = 931652

5 - 163EFBA585A56241 -> 1602995205720859201

6 - 1602995205720859201 / 931649 => 1720599931649
*/
Console.WriteLine(SecretKey.Decrypt("15F1317OD8557AEA1C086O435"));

