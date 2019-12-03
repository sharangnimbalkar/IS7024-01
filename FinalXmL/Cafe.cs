﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var chicagoCafe = ChicagoCafe.FromJson(jsonString);

namespace Cafe
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ChicagoCafe
    {
        [JsonProperty("zip_code", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ZipCode { get; set; }

        [JsonProperty(":@computed_region_43wa_7qmu", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ComputedRegion43Wa7Qmu { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("ward_precinct")]
        public string WardPrecinct { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("street_type", NullValueHandling = NullValueHandling.Ignore)]
        public StreetType? StreetType { get; set; }

        [JsonProperty("payment_date")]
        public DateTimeOffset PaymentDate { get; set; }

        [JsonProperty(":@computed_region_rpca_8um6", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ComputedRegionRpca8Um6 { get; set; }

        [JsonProperty("issued_date")]
        public DateTimeOffset IssuedDate { get; set; }

        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        [JsonProperty("precinct", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Precinct { get; set; }

        [JsonProperty("ward")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ward { get; set; }

        [JsonProperty("doing_business_as_name")]
        public string DoingBusinessAsName { get; set; }

        [JsonProperty("police_district", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? PoliceDistrict { get; set; }

        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }

        [JsonProperty("street_direction")]
        public StreetDirection StreetDirection { get; set; }

        [JsonProperty("permit_number")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PermitNumber { get; set; }

        [JsonProperty(":@computed_region_bdys_3d7i", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ComputedRegionBdys3D7I { get; set; }

        [JsonProperty(":@computed_region_6mkv_f3dw", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ComputedRegion6MkvF3Dw { get; set; }

        [JsonProperty("address_number_start")]
        public string AddressNumberStart { get; set; }

        [JsonProperty("address_number")]
        public string AddressNumber { get; set; }

        [JsonProperty("expiration_date")]
        public DateTimeOffset ExpirationDate { get; set; }

        [JsonProperty("account_number")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AccountNumber { get; set; }

        [JsonProperty("site_number")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SiteNumber { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("legal_name")]
        public string LegalName { get; set; }

        [JsonProperty(":@computed_region_vrxf_vc4k", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ComputedRegionVrxfVc4K { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public State? State { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("human_address")]
        public HumanAddress HumanAddress { get; set; }

        [JsonProperty("needs_recoding")]
        public bool NeedsRecoding { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public enum City { Chicago };

    public enum HumanAddress { AddressCityStateZip };

    public enum State { Il };

    public enum StreetDirection { E, N, S, W };

    public enum StreetType { Ave, Blvd, Ct, Dr, Hwy, Pkwy, Pl, Rd, St };

    public partial class ChicagoCafe
    {
        public static ChicagoCafe[] FromJson(string json) => JsonConvert.DeserializeObject<ChicagoCafe[]>(json, Cafe.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ChicagoCafe[] self) => JsonConvert.SerializeObject(self, Cafe.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CityConverter.Singleton,
                HumanAddressConverter.Singleton,
                StateConverter.Singleton,
                StreetDirectionConverter.Singleton,
                StreetTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class CityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(City) || t == typeof(City?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "CHICAGO")
            {
                return City.Chicago;
            }
            throw new Exception("Cannot unmarshal type City");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (City)untypedValue;
            if (value == City.Chicago)
            {
                serializer.Serialize(writer, "CHICAGO");
                return;
            }
            throw new Exception("Cannot marshal type City");
        }

        public static readonly CityConverter Singleton = new CityConverter();
    }

    internal class HumanAddressConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HumanAddress) || t == typeof(HumanAddress?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "{\"address\": \"\", \"city\": \"\", \"state\": \"\", \"zip\": \"\"}")
            {
                return HumanAddress.AddressCityStateZip;
            }
            throw new Exception("Cannot unmarshal type HumanAddress");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HumanAddress)untypedValue;
            if (value == HumanAddress.AddressCityStateZip)
            {
                serializer.Serialize(writer, "{\"address\": \"\", \"city\": \"\", \"state\": \"\", \"zip\": \"\"}");
                return;
            }
            throw new Exception("Cannot marshal type HumanAddress");
        }

        public static readonly HumanAddressConverter Singleton = new HumanAddressConverter();
    }

    internal class StateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(State) || t == typeof(State?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "IL")
            {
                return State.Il;
            }
            throw new Exception("Cannot unmarshal type State");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (State)untypedValue;
            if (value == State.Il)
            {
                serializer.Serialize(writer, "IL");
                return;
            }
            throw new Exception("Cannot marshal type State");
        }

        public static readonly StateConverter Singleton = new StateConverter();
    }

    internal class StreetDirectionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StreetDirection) || t == typeof(StreetDirection?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "E":
                    return StreetDirection.E;
                case "N":
                    return StreetDirection.N;
                case "S":
                    return StreetDirection.S;
                case "W":
                    return StreetDirection.W;
            }
            throw new Exception("Cannot unmarshal type StreetDirection");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StreetDirection)untypedValue;
            switch (value)
            {
                case StreetDirection.E:
                    serializer.Serialize(writer, "E");
                    return;
                case StreetDirection.N:
                    serializer.Serialize(writer, "N");
                    return;
                case StreetDirection.S:
                    serializer.Serialize(writer, "S");
                    return;
                case StreetDirection.W:
                    serializer.Serialize(writer, "W");
                    return;
            }
            throw new Exception("Cannot marshal type StreetDirection");
        }

        public static readonly StreetDirectionConverter Singleton = new StreetDirectionConverter();
    }

    internal class StreetTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StreetType) || t == typeof(StreetType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AVE":
                    return StreetType.Ave;
                case "BLVD":
                    return StreetType.Blvd;
                case "CT":
                    return StreetType.Ct;
                case "DR":
                    return StreetType.Dr;
                case "HWY":
                    return StreetType.Hwy;
                case "PKWY":
                    return StreetType.Pkwy;
                case "PL":
                    return StreetType.Pl;
                case "RD":
                    return StreetType.Rd;
                case "ST":
                    return StreetType.St;
            }
            throw new Exception("Cannot unmarshal type StreetType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StreetType)untypedValue;
            switch (value)
            {
                case StreetType.Ave:
                    serializer.Serialize(writer, "AVE");
                    return;
                case StreetType.Blvd:
                    serializer.Serialize(writer, "BLVD");
                    return;
                case StreetType.Ct:
                    serializer.Serialize(writer, "CT");
                    return;
                case StreetType.Dr:
                    serializer.Serialize(writer, "DR");
                    return;
                case StreetType.Hwy:
                    serializer.Serialize(writer, "HWY");
                    return;
                case StreetType.Pkwy:
                    serializer.Serialize(writer, "PKWY");
                    return;
                case StreetType.Pl:
                    serializer.Serialize(writer, "PL");
                    return;
                case StreetType.Rd:
                    serializer.Serialize(writer, "RD");
                    return;
                case StreetType.St:
                    serializer.Serialize(writer, "ST");
                    return;
            }
            throw new Exception("Cannot marshal type StreetType");
        }

        public static readonly StreetTypeConverter Singleton = new StreetTypeConverter();
    }
}
