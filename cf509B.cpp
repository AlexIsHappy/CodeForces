#include <algorithm>
#include <iomanip>
#include <istream>
#include <map>
#include <numeric>
#include <ostream>
#include <set>
#include <sstream>
#include <string>
#include <utility>
#include <vector>
using namespace std;
// Powered by caide (code generator, tester, and library code inliner)


class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		int n, c; in >> n >> c;

		vector<int> k;

		int mx = 0;
		int mn = 101;
		for (int i = 0; i < n; i++){
			int cur; in >> cur;
			if (cur > mx) 
				mx = cur;
			if (cur < mn)
				mn = cur;
			k.push_back(cur);
		}

		if ( (mx - mn) > c){
			out << "NO"; return;
		} 

		out << "YES" << "\n";
		for (int i = 0; i < n; i++){

			int ind = 0;
			
			while (ind < k[i]){
				out << (ind % c) + 1 << " ";
				ind++;
			}
			out << "\n";
		}


    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
