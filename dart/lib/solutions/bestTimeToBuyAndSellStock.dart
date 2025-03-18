
int? solution(List<int> prices){

    int cheapestPrice = prices[0]; 
    int highestProfit = 0;

    for(int i = 0 ; i< prices.length; i++){ 
        
        cheapestPrice = prices[i] < cheapestPrice ? prices[i] : cheapestPrice;  
         
        int profit = prices[i] - cheapestPrice;

        highestProfit = profit > highestProfit ? profit : highestProfit;

    }
    
    return highestProfit;
}