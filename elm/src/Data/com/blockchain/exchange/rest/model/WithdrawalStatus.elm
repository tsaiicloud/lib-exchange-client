{-
   Blockchain.com Exchange REST API
   ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 

   The version of the OpenAPI document: 1.0.0

   NOTE: This file is auto generated by the openapi-generator.
   https://github.com/openapitools/openapi-generator.git
   Do not edit this file manually.
-}


module Data.WithdrawalStatus exposing (WithdrawalStatus(..), decoder, encode, toString)

import Dict exposing (Dict)
import Json.Decode as Decode exposing (Decoder)
import Json.Decode.Pipeline exposing (optional, required)
import Json.Encode as Encode


type WithdrawalStatus
    = REJECTED
    | PENDING
    | REFUNDED
    | FAILED
    | COMPLETED



decoder : Decoder WithdrawalStatus
decoder =
    Decode.string
        |> Decode.andThen
            (\str ->
                case str of
                    "REJECTED" ->
                        Decode.succeed REJECTED

                    "PENDING" ->
                        Decode.succeed PENDING

                    "REFUNDED" ->
                        Decode.succeed REFUNDED

                    "FAILED" ->
                        Decode.succeed FAILED

                    "COMPLETED" ->
                        Decode.succeed COMPLETED

                    other ->
                        Decode.fail <| "Unknown type: " ++ other
            )



encode : WithdrawalStatus -> Encode.Value
encode model =
    case model of
        REJECTED ->
            Encode.string "REJECTED"

        PENDING ->
            Encode.string "PENDING"

        REFUNDED ->
            Encode.string "REFUNDED"

        FAILED ->
            Encode.string "FAILED"

        COMPLETED ->
            Encode.string "COMPLETED"




toString : WithdrawalStatus -> String
toString model =
    case model of
        REJECTED ->
            "REJECTED"

        PENDING ->
            "PENDING"

        REFUNDED ->
            "REFUNDED"

        FAILED ->
            "FAILED"

        COMPLETED ->
            "COMPLETED"



