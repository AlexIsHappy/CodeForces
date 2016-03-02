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

int charToNum(char c) {
	if (c >= 'a' && c <= 'z') return c - 'a';
	else return c - 'A' + 26;
}
int cnt1[55];
int cnt2[55];

class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		string s, t; in >> s >> t;


		for (int i = 0; s[i] != 0; i++) 
			cnt1[charToNum(s[i])]++;
		for (int i = 0; t[i] != 0; i++) 
			cnt2[charToNum(t[i])]++;

		int ans1 = 0; int ans2 = 0;

		for (int i = 0; i < 52; i++) {
			if (cnt1[i] != 0 || cnt2[i]){
				out << i << " " << cnt1[i] << " " << cnt2[i] << "\n";
			}
		}
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
