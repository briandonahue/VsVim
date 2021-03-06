﻿#light

namespace Vim

open Microsoft.VisualStudio.Text
open Microsoft.VisualStudio.Text.Editor
open Microsoft.VisualStudio.Text.Operations
open Microsoft.VisualStudio.Utilities


type internal VimBuffer =

    new : VimBufferData * IIncrementalSearch * IMotionUtil * ITextStructureNavigator * IVimWindowSettings -> VimBuffer

    member AddMode : IMode -> unit

    member RaiseErrorMessage : string -> unit

    member RaiseWarningMessage : string -> unit

    member RaiseStatusMessage : string -> unit

    interface IVimBuffer

