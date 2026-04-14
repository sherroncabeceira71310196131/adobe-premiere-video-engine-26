#include <iostream>
#include <string>

int main(int argc, char* argv[]) {
    std::cout << "[*] PremiereVideo Engine...\n";

    if (argc < 2) {
        std::cerr << "[!] Usage: ./premierevideo --timeline <id>\n";
        return 1;
    }

    VideoCore::TimelineParser parser("config.json");
    std::string timelineID = argv[2];
    parser.extractStems(timelineID);

    std::cout << "[+] Timeline processed.\n";
    return 0;
}

