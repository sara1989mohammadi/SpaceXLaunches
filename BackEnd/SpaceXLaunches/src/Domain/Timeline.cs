using Newtonsoft.Json;

namespace Domain
{
    public class Timeline : BaseEntity
    {
        public int? webcast_liftoff { get; set; }
        public int? go_for_prop_loading { get; set; }
        public int? rp1_loading { get; set; }
        public int? stage1_lox_loading { get; set; }
        public int? stage2_lox_loading { get; set; }
        public int? engine_chill { get; set; }
        public int? prelaunch_checks { get; set; }
        public int? propellant_pressurization { get; set; }
        public int? go_for_launch { get; set; }
        public int? ignition { get; set; }
        public int? liftoff { get; set; }
        public int? maxq { get; set; }
        public int? meco { get; set; }
        public int? stage_sep { get; set; }
        public int? second_stage_ignition { get; set; }

        [JsonProperty("seco-1")]
        public int? seco1 { get; set; }
        public int? dragon_separation { get; set; }
        public int? dragon_solar_deploy { get; set; }
        public int? dragon_bay_door_deploy { get; set; }
        public int? fairing_deploy { get; set; }
        public int? payload_deploy { get; set; }
        public int? second_stage_restart { get; set; }

        [JsonProperty("seco-2")]
        public int? seco2 { get; set; }
        public int? webcast_launch { get; set; }
        public int? payload_deploy_1 { get; set; }
        public int? payload_deploy_2 { get; set; }
        public int? first_stage_boostback_burn { get; set; }
        public int? first_stage_entry_burn { get; set; }
        public int? first_stage_landing { get; set; }
        public int? beco { get; set; }
        public int? side_core_sep { get; set; }
        public int? side_core_boostback { get; set; }
        public int? center_stage_sep { get; set; }
        public int? center_core_boostback { get; set; }
        public int? side_core_entry_burn { get; set; }
        public int? center_core_entry_burn { get; set; }
        public int? side_core_landing { get; set; }
        public int? center_core_landing { get; set; }
        public int? first_stage_landing_burn { get; set; }
        public int? stage1_rp1_loading { get; set; }
        public int? stage2_rp1_loading { get; set; }

        [JsonProperty("seco-3")]
        public int? seco3 { get; set; }

        [JsonProperty("seco-4")]
        public int? seco4 { get; set; }
    }


}
