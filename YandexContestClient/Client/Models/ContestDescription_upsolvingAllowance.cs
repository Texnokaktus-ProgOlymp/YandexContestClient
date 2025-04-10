// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace YandexContestClient.Client.Models
{
    /// <summary>Upsolving settings - `ALLOWED_AFTER_PARTICIPATION_ENDS` — participant can upsolve after their participation ends - `ALLOWED_AFTER_CONTEST_ENDS` — participant can upsolve after contest is finished for everyone - `PROHIBITED` — participant can not upsolve</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ContestDescription_upsolvingAllowance
    {
        [EnumMember(Value = "ALLOWED_AFTER_PARTICIPATION_ENDS")]
        #pragma warning disable CS1591
        ALLOWED_AFTER_PARTICIPATION_ENDS,
        #pragma warning restore CS1591
        [EnumMember(Value = "ALLOWED_AFTER_CONTEST_ENDS")]
        #pragma warning disable CS1591
        ALLOWED_AFTER_CONTEST_ENDS,
        #pragma warning restore CS1591
        [EnumMember(Value = "PROHIBITED")]
        #pragma warning disable CS1591
        PROHIBITED,
        #pragma warning restore CS1591
    }
}
