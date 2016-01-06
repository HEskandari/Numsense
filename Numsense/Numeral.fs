﻿[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Ploeh.Numsense.Numeral

open Ploeh.Numsense.InternalDsl

let toDanish        = Danish.toDanishImp 1
let tryParseDanish  =  Danish.tryParseDanishImp

let toEnglish       = English.toEnglishImp
let tryParseEnglish = English.tryParseEnglishImp

let toFarsi         = Farsi.toFarsiImp
let tryParseFarsi   = Farsi.tryParseFarsiImp