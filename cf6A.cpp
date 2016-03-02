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
		int a, b, c, s; in >> a >> b >> c >> s;

		vector<int> sid;

		sid.push_back(a);
		sid.push_back(b);
		sid.push_back(c);
		sid.push_back(s);

		bool isSeg = false;

		for (int i = 0; i < 4; i++){
			vector<int> sd;

			for (int j = 0; j < 4; j++){
				if (i != j){
					sd.push_back(sid[j]);
				}
			}

			if (((sd[0] + sd[1]) > sd[2]) && ((sd[0] + sd[2]) > sd[1]) && ((sd[1] + sd[2]) > sd[0])){
				out << "TRIANGLE";
				return;
			}

			if (((sd[0] + sd[1]) == sd[2]) || ((sd[0] + sd[2]) == sd[1]) || ((sd[1] + sd[2]) == sd[0])){
				isSeg = true;
			}
		}


		if (isSeg)
			out << "SEGMENT";
		else
			out << "IMPOSSIBLE";
		
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
