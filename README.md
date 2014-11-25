Homework assignment HW1: Part I Basic Concepts
===
First of all, note the following:

You need to submit one pdf-file, where you report the sequence of steps to find T(n) analytically, the most interesting and challenging part in you implementation(some code), your  results and conclusions.
The pdf-file should be from 3 to 7 pages long, no larger and no shorter.
You have to present during class on Dec. 3rd your program running for this HW1, as well as, present your results and be ready to answer some questions from the audience.
Last but not least, eLas as well as homework assignments are individual work, you can discuss with your classmates and do some initial programming together, but at some point you have to work on your own and write your own final implementation, perform your own experiments obtain your own results and write down your own conclusions. Only HW3 (Team work) is to be done in groups and it is the only homework assignment to be done in a team.
Homework assignment  HW1:

You are given the following two functions to compute the exponentiation of a number:

func1 (iterative exponentiation):

double func1(x,n)
{
   double res=1;
   while(n>0){
      res*=x;
     n -=1;
   }
   return res;
}
func2 (recursive exponentiation)

double func2(x,n)
{
  if (n==1)
      return x;
   else
      return x*func2(x,n-1);
}
1.- (15 pts)Your first task consists in implementing a third function, func3, to compute the exponentiation of a number. This has to be a recursive function that runs much faster than func2 and uses the following strategy for reducing the complexity of the exponentiation:

xn can be computed in a

much faster way using the exponential law

xm*n = (xm)n

Show that using this the number of recursive calls can be reduce in half for n even.

2.- (15 pts)Show that the complexity of the algorithm of func3 (using a T(n) function to express the number of recursive calls) leads to an order O(log n).

3.- (20 pts) Obtain for each algorithm a normalized histogram showing the probability distribution of the CPU-time for 3 different large input-size. 

4.- (20 pts) Use the data of your histograms above and compare the empirical CPU-time mean and variance of the three algorithms with their corresponding statistical significance tests, i.e. t-test and F-test.
5.- (30 pts) Compare the rate of growth of the CPU-time for the three algorithms with their theoretical counterparts. Show that the empirical evaluations (use power law functions) correspond to the theoretical expected CPU-time.
