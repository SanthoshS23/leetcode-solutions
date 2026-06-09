function maxProfit(prices: number[]): number {
    let Initialminvalue = prices[0];
    let maxprofit = 0;
    for (let i=1;i<prices.length;i++) {
        if (prices[i]<Initialminvalue) {
            Initialminvalue = prices[i]
        } else {
            const profit = prices[i] - Initialminvalue;
            maxprofit = Math.max(maxprofit,profit);
        }
    }
    return maxprofit;
};