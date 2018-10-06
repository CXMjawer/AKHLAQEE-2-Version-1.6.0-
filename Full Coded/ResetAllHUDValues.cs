using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAllHUDValues : MonoBehaviour {

	public void SetValues () {

					CountD.timeLeft=1000;
			        InfoCollected.CoinsAmount=0;
					ScoreCollected.ScoreAmount=0;
					StarsCollected.StarsAmount=0;
					TrophiesCollected.TrophiesAmount=0;
					PercentCollected.PercentNum=0;
					QuizCollected.QuizAmount=0;
					Cleaning.Clearing=0;
					GatheringSpecial.CollectFiveInfosToGetOneStar = 0;
					GatheringSpecial.CollectFiveStarsToGetOneTrophy = 0;
					Gathering.CollectFiveInfosToGetOneStar=0;
					Gathering.CollectFiveStarsToGetOneTrophy = 0;
	}	
} 