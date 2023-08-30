﻿using LuaLanguageServer.LuaCore.Kind;

namespace LuaLanguageServer.LuaCore.Compile.Parser;

public interface IParser : IMarkerEventContainer
{
    public void Expect(LuaTokenKind kind);

    public void Accept(LuaTokenKind kind);

    public void Bump();

    public LuaTokenKind Current { get; }
}
