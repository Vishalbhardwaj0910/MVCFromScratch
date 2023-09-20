{ pkgs }: {
    deps = [
        pkgs.sqlite.bin
        pkgs.wget
        pkgs.dotnet-sdk
    ];
}