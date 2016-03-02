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

		map<string, string> nam;

		for (int i = 0; i < n; i++){
			string old, nw; in >> old >> nw;


			map<string, string>::iterator it;
			if (nam.find(old) == nam.end()){
				nam.insert(make_pair(nw, old));
			}
			else{
				it = nam.find(old);
				pair<string, string> nz = make_pair(nw, it->second);
				nam.erase(it);
				nam.insert(nz);
			}
		}

		out << nam.size() << "\n";
			map<string, string>::iterator itv;
		for (itv = nam.begin(); itv != nam.end(); itv++){
			out << itv->second << " " << itv->first << "\n";
		}
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
