namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext9 ContextSwitchInterpreter
								if(AddContext9 != null)
								{
									GODelegate Lambda10 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											//ContextStatement UnityEngine.GameObject entity ContextSwitchInterpreter
											if(entity != null)
											{
												
												{
													SpaceMarker subContext11 = (SpaceMarker)entity.GetComponent(typeof(SpaceMarker)); //IsContext = True IsNew = False
													//ContextStatement SpaceMarker subContext11 ContextSwitchInterpreter
													if(subContext11 != null)
													{
														
														{
															Space subContext12 = subContext11.CurrentSpace; //IsContext = True IsNew = False
															//ContextStatement Space subContext12 ContextPropertySwitchInterpreter
															if(subContext12 != null)
															{
																Place OperandVar14 = default(Place); //IsContext = False IsNew = False
																Place StoredVariable13 = ((Place)subContext12.GetComponent(typeof(Place))); //IsContext = False IsNew = False
																if(StoredVariable13 != null)
																{
																	OperandVar14 = StoredVariable13;
																}
																subContext12.Detach( (OperandVar14));
															}
														}
													}
												}
											}
										}
									};
									AddContext9.OnDestruction(Lambda10);
								}
							}
							Place AddContext15 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext15 ContextSwitchInterpreter
								if(AddContext15 != null)
								{
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop16 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar17 = prop16;
									AddContext15.Size = (System.Int32)( (OperandVar17));
								}
							}
							Named AddContext18 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext18 ContextSwitchInterpreter
								if(AddContext18 != null)
								{
									
									
									
									AddContext18.Set( ("prefix"), (0f), ("Location of: "));
									
									
									System.String OperandVar20 = default(System.String); //IsContext = False IsNew = False
									System.String prop19 = External.RandomName(); //IsContext = False IsNew = False
									if(prop19 != null)
									{
										OperandVar20 = prop19;
									}
									AddContext18.Set( ("main_name"), (1f), (OperandVar20));
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar22 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable21 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable21 != null)
						{
							OperandVar22 = StoredVariable21;
						}
						subContext5.Attach( (OperandVar22));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar36 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable23 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable23 != null)
			{
				System.Boolean ifResult24; //IsContext = False IsNew = False
				
				System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop25 = StoredVariable23.ShowedObject; //IsContext = False IsNew = False
				if(prop25 != null)
				{
					System.Boolean ifResult26; //IsContext = False IsNew = False
					System.Boolean OperandVar30 = default(System.Boolean); //IsContext = False IsNew = False
					Named OperandVar28 = default(Named); //IsContext = False IsNew = False
					Named StoredVariable27 = ((Named)prop25.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable27 != null)
					{
						OperandVar28 = StoredVariable27;
					}
					System.Boolean prop29 = External.Has( (OperandVar28)); //IsContext = False IsNew = False
					OperandVar30 = prop29;
					if(ifResult26 =  (OperandVar30))
					{
						OperandVar31 = ifResult26;
					}
				}
				
				System.Boolean OperandVar35 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar33 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable32 = ((Blackboards.named_ui_marker)root.GetComponent(typeof(Blackboards.named_ui_marker))); //IsContext = False IsNew = False
				if(StoredVariable32 != null)
				{
					OperandVar33 = StoredVariable32;
				}
				System.Boolean prop34 = External.Has( (OperandVar33)); //IsContext = False IsNew = False
				OperandVar35 = prop34;
				if(ifResult24 = ( ( (OperandVar31))) && ( (!(OperandVar35))))
				{
					applicable = true;
					OperandVar36 = applicable;
				}
			}
			return (System.Boolean) (OperandVar36);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.named_ui_marker>();
			
			{
				UiObject subContext37 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext37 ContextSwitchInterpreter
				if(subContext37 != null)
				{
					Named OperandVar40 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop38 = subContext37.ShowedObject; //IsContext = False IsNew = False
					if(prop38 != null)
					{
						Named StoredVariable39 = ((Named)prop38.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable39 != null)
						{
							OperandVar40 = StoredVariable39;
						}
					}
					Named showed_named =  (OperandVar40); //IsContext = False IsNew = False
					TextField fld = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField fld ContextSwitchInterpreter
						if(fld != null)
						{
							System.String OperandVar42 = default(System.String); //IsContext = False IsNew = False
							System.String prop41 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop41 != null)
							{
								OperandVar42 = prop41;
							}
							fld.Set( (OperandVar42));
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda43 = () => 
									{
										
										{
											//ContextStatement TextField fld ContextSwitchInterpreter
											if(fld != null)
											{
												System.String OperandVar45 = default(System.String); //IsContext = False IsNew = False
												System.String prop44 = showed_named.FullName; //IsContext = False IsNew = False
												if(prop44 != null)
												{
													OperandVar45 = prop44;
												}
												fld.Set( (OperandVar45));
											}
										}
									};
									showed_named.OnUpdate(Lambda43);
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar53 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable46 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable46 != null)
			{
				Place StoredVariable47 = ((Place)StoredVariable46.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable47 != null)
				{
					System.Boolean ifResult48; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar50 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop49 = StoredVariable47.Agents; //IsContext = False IsNew = False
					if(prop49 != null)
					{
						OperandVar50 = prop49;
					}
					
					
					
					System.Boolean OperandVar52 = default(System.Boolean); //IsContext = False IsNew = False
					
					System.Boolean prop51 = StoredVariable46.HasMarker( ("agents_pool")); //IsContext = False IsNew = False
					OperandVar52 = prop51;
					if(ifResult48 = ( (( ( (OperandVar50 != null ? OperandVar50.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar52))))
					{
						applicable = true;
						OperandVar53 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar53);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext54 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext54 ContextSwitchInterpreter
				if(subContext54 != null)
				{
					
					subContext54.Size = (System.Int32)( (5f));
					System.Single OperandVar56 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop55 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar56 = prop55;
					for (int i = 0; i <  (OperandVar56); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag57 = ag; //IsContext = True IsNew = False
							Entity AddContext58 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext58 ContextSwitchInterpreter
								if(AddContext58 != null)
								{
									GODelegate Lambda59 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											//ContextStatement UnityEngine.GameObject entity ContextSwitchInterpreter
											if(entity != null)
											{
												
												{
													PlaceMarker subContext60 = (PlaceMarker)entity.GetComponent(typeof(PlaceMarker)); //IsContext = True IsNew = False
													//ContextStatement PlaceMarker subContext60 ContextSwitchInterpreter
													if(subContext60 != null)
													{
														
														{
															Place subContext61 = subContext60.CurrentPlace; //IsContext = True IsNew = False
															//ContextStatement Place subContext61 ContextPropertySwitchInterpreter
															if(subContext61 != null)
															{
																Agent OperandVar63 = default(Agent); //IsContext = False IsNew = False
																Agent StoredVariable62 = ((Agent)subContext61.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
																if(StoredVariable62 != null)
																{
																	OperandVar63 = StoredVariable62;
																}
																subContext61.Detach( (OperandVar63));
															}
														}
													}
												}
											}
										}
									};
									AddContext58.OnDestruction(Lambda59);
								}
							}
							Agent AddContext64 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext65 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext65 ContextSwitchInterpreter
								if(AddContext65 != null)
								{
									System.Single OperandVar67 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop66 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar67 = prop66;
									AddContext65.Age = (System.Int32)( (OperandVar67));
								}
							}
							Named AddContext68 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext68 ContextSwitchInterpreter
								if(AddContext68 != null)
								{
									
									
									
									AddContext68.Set( ("prefix"), (0f), ("Agent: "));
									
									
									System.String OperandVar70 = default(System.String); //IsContext = False IsNew = False
									System.String prop69 = External.RandomName(); //IsContext = False IsNew = False
									if(prop69 != null)
									{
										OperandVar70 = prop69;
									}
									AddContext68.Set( ("main_name"), (1f), (OperandVar70));
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar72 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable71 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable71 != null)
						{
							OperandVar72 = StoredVariable71;
						}
						subContext54.Attach( (OperandVar72));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar79 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable73 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable73 != null)
			{
				System.Boolean ifResult74; //IsContext = False IsNew = False
				System.Boolean OperandVar78 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar76 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable75 = ((Blackboards.event_marker)StoredVariable73.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable75 != null)
				{
					OperandVar76 = StoredVariable75;
				}
				System.Boolean prop77 = External.Has( (OperandVar76)); //IsContext = False IsNew = False
				OperandVar78 = prop77;
				if(ifResult74 = !(OperandVar78))
				{
					applicable = true;
					OperandVar79 = applicable;
				}
			}
			return (System.Boolean) (OperandVar79);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar86 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable80 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable80 != null)
			{
				System.Boolean ifResult81; //IsContext = False IsNew = False
				System.Boolean OperandVar85 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar83 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable82 = ((Blackboards.personality)StoredVariable80.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable82 != null)
				{
					OperandVar83 = StoredVariable82;
				}
				System.Boolean prop84 = External.Has( (OperandVar83)); //IsContext = False IsNew = False
				OperandVar85 = prop84;
				if(ifResult81 = !(OperandVar85))
				{
					applicable = true;
					OperandVar86 = applicable;
				}
			}
			return (System.Boolean) (OperandVar86);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar93 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable87 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable87 != null)
			{
				System.Boolean ifResult88; //IsContext = False IsNew = False
				System.Boolean OperandVar92 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar90 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable89 = ((Blackboards.aged_generation)StoredVariable87.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable89 != null)
				{
					OperandVar90 = StoredVariable89;
				}
				System.Boolean prop91 = External.Has( (OperandVar90)); //IsContext = False IsNew = False
				OperandVar92 = prop91;
				if(ifResult88 = !(OperandVar92))
				{
					applicable = true;
					OperandVar93 = applicable;
				}
			}
			return (System.Boolean) (OperandVar93);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar102 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable94 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable94 != null)
			{
				Lore StoredVariable95 = ((Lore)StoredVariable94.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable95 != null)
				{
					Place StoredVariable96 = ((Place)StoredVariable95.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable96 != null)
					{
						System.Boolean ifResult97; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar99 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop98 = StoredVariable96.Agents; //IsContext = False IsNew = False
						if(prop98 != null)
						{
							OperandVar99 = prop98;
						}
						
						
						
						System.Boolean OperandVar101 = default(System.Boolean); //IsContext = False IsNew = False
						
						System.Boolean prop100 = StoredVariable94.HasMarker( ("lore_pool")); //IsContext = False IsNew = False
						OperandVar101 = prop100;
						if(ifResult97 = ( (( ( (OperandVar99 != null ? OperandVar99.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar101))))
						{
							applicable = true;
							OperandVar102 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar102);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext103 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext103 ContextSwitchInterpreter
				if(subContext103 != null)
				{
					
					subContext103.Size = (System.Int32)( (5f));
					System.Single OperandVar105 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop104 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar105 = prop104;
					for (int i = 0; i <  (OperandVar105); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag106 = ag; //IsContext = True IsNew = False
							Entity AddContext107 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext107 ContextSwitchInterpreter
								if(AddContext107 != null)
								{
									GODelegate Lambda108 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											//ContextStatement UnityEngine.GameObject entity ContextSwitchInterpreter
											if(entity != null)
											{
												
												{
													PlaceMarker subContext109 = (PlaceMarker)entity.GetComponent(typeof(PlaceMarker)); //IsContext = True IsNew = False
													//ContextStatement PlaceMarker subContext109 ContextSwitchInterpreter
													if(subContext109 != null)
													{
														
														{
															Place subContext110 = subContext109.CurrentPlace; //IsContext = True IsNew = False
															//ContextStatement Place subContext110 ContextPropertySwitchInterpreter
															if(subContext110 != null)
															{
																Agent OperandVar112 = default(Agent); //IsContext = False IsNew = False
																Agent StoredVariable111 = ((Agent)subContext110.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
																if(StoredVariable111 != null)
																{
																	OperandVar112 = StoredVariable111;
																}
																subContext110.Detach( (OperandVar112));
															}
														}
													}
												}
											}
										}
									};
									AddContext107.OnDestruction(Lambda108);
								}
							}
							Agent AddContext113 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext114 = (Blackboards.historical_person)ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext115 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext115 ContextSwitchInterpreter
								if(AddContext115 != null)
								{
									System.Single OperandVar117 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop116 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar117 = prop116;
									AddContext115.Age = (System.Int32)( (OperandVar117));
								}
							}
							Named AddContext118 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext118 ContextSwitchInterpreter
								if(AddContext118 != null)
								{
									
									
									
									AddContext118.Set( ("prefix"), (0f), ("Historical person: "));
									
									
									System.String OperandVar120 = default(System.String); //IsContext = False IsNew = False
									System.String prop119 = External.RandomName(); //IsContext = False IsNew = False
									if(prop119 != null)
									{
										OperandVar120 = prop119;
									}
									AddContext118.Set( ("main_name"), (1f), (OperandVar120));
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar122 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable121 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable121 != null)
						{
							OperandVar122 = StoredVariable121;
						}
						subContext103.Attach( (OperandVar122));
					}
				}
			}
		}
        }
    }
    
    public class change_name_historical_action : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar129 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.historical_person StoredVariable123 = ((Blackboards.historical_person)root.GetComponent(typeof(Blackboards.historical_person))); //IsContext = False IsNew = False
			if(StoredVariable123 != null)
			{
				Named StoredVariable124 = ((Named)StoredVariable123.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable124 != null)
				{
					Agent StoredVariable125 = ((Agent)StoredVariable124.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
					if(StoredVariable125 != null)
					{
						System.Boolean ifResult126; //IsContext = False IsNew = False
						
						System.Boolean OperandVar128 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop127 = StoredVariable125.Act; //IsContext = False IsNew = False
						OperandVar128 = prop127;
						
						
						if(ifResult126 = ( ( (OperandVar128))) == ( ( (true))))
						{
							applicable = true;
							OperandVar129 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar129);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext130 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext130 ContextSwitchInterpreter
				if(subContext130 != null)
				{
					
					System.String OperandVar132 = default(System.String); //IsContext = False IsNew = False
					System.String prop131 = External.RandomName(); //IsContext = False IsNew = False
					if(prop131 != null)
					{
						OperandVar132 = prop131;
					}
					subContext130.Switch( ("main_name"), (OperandVar132));
				}
			}
		}
        }
    }
}
