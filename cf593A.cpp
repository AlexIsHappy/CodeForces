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
		int n; in >> n;

		vector<string> s;


		set<char> os;
		for (int i = 0; i < n; i++){
			string cs; in >> cs;
			set<char> smb;
			for (int j = 0; j < cs.length(); j++){
				smb.insert(cs[j]);
				os.insert(cs[j]);
			}

			if (smb.size() <= 2){
				s.push_back(cs);
			}

		}

		if (os.size() <= 2){
			int cnt = 0;
			for (int i = 0; i < s.size(); i++){
				cnt += s[i].length();
			}
			out << cnt;
			return;
		}


		int ans = 0;

		for (int i = 0; i < s.size(); i++){
			int cm = 0;
			cm += s[i].length();
			ans = max(ans, cm);

			for (int j = 0; j < s.size(); j++){
				if (j != i){
					bool isf = true;
					for (int b = 0; b < s[j].length(); b++){
						if (s[i].find(s[j][b]) == string::npos){
						isf = false;
						break;
						}
					}

					if (isf)
						cm += s[j].length();
				}
			}

			ans = max(ans, cm);

		}

		out << ans;

    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
