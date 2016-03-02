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
		string s; in >> s;

		vector<int> c(26, 0);

		for (int i = 0; i < s.length(); i++){
			c[s[i] - 'a']++;
		}

		int n = 0;
		for (int i = 0; i < 26; i++){
			if (c[i] % 2 != 0){
				n++;
			}
		}

		if (n <= 1){
			out << "First";
		}
		else{
			if (n % 2 == 0){
				out << "Second";
			}
			else
				out << "First";
		}

    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
